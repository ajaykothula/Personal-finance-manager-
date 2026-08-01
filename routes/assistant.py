from flask import Blueprint, render_template, request, jsonify

assistant_bp = Blueprint("assistant", __name__)

@assistant_bp.route("/assistant")
def assistant():
    return render_template("assistant.html")

@assistant_bp.route("/ask-ai", methods=["POST"])
def ask():
    data = request.get_json()
    question = data["message"]

    return jsonify({"reply": "Hello " + question})
