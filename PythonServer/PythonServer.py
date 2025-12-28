from flask import Flask , jsonify
from waitress import serve

app = Flask(__name__)

@app.route("/greet",methods=["GET"])
def great():
    return jsonify({"message": "Mohamed Gonem was here!"})
if __name__ == '__main__':
    serve(app , host='127.0.0.1', port=5050)
