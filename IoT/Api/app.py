from flask import Flask, json, request, jsonify
import pandas as pd

app = Flask(__name__)
PATH_FILES = 'dados_maq.csv'


# Funcionalidades
@app.route('/')
def teste() -> str:
    return 'Testando Api'


@app.route("/getCSV", methods=['GET'])
def getCSV():
    df = pd.read_csv(PATH_FILES)
    result = df.to_json(orient="records")
    dados = json.loads(result)
    return json.dumps(dados)


@app.route('/gravarDados', methods=['POST'])
def postJson():
    dados = request.json
    with open("dados_maq.csv", "a") as arquivo:
        arquivo.write(str(dados["id"]) + "," + str(dados["temp"]) + "," +
                      str(dados["ruido"]) + "," + str(dados["vibra"]))
        arquivo.close()
        return jsonify(dados)


# Api
app.run(host='0.0.0.0')
