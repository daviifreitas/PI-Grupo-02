from flask import Flask, json, request, jsonify, Response
import pandas as pd


# Ter o Arquivo dados_maq.csv baixado na sua pasta
# Para utilizar é necessário informar no PATH_FILE o local que foi colocado o arquivo
app = Flask(__name__)
PATH_FILE = 'dados_maq.csv'


# Funcionalidades
@app.route('/')
def teste() -> str:
    return 'Testando Api'


@app.route("/readCSV", methods=['GET'])
def getCSV() -> str:
    read = pd.read_csv(PATH_FILE)
    dados = read.to_json(orient="records")
    tabela = json.loads(dados)
    return json.dumps(tabela)


@app.route('/gravarDados', methods=['POST'])
def postJson() -> Response:
    dados = request.json
    with open("dados_maq.csv", "a") as arquivo:
        arquivo.write(str(dados["id"]) + "," + str(dados["temp"]) + "," +
                      str(dados["ruido"]) + "," + str(dados["vibra"]))
        arquivo.close()
        return jsonify(dados)


# Informando que a API vai estar no seu localhost
app.run(host='0.0.0.0')
