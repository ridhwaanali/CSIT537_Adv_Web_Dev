from flask import Flask, render_template
from component import component
from video import video
from part import part

app= Flask(__name__)
@app.route("/")
def home():
    return render_template("home.html")

app.register_blueprint(component, url_prefix="/component")
app.register_blueprint(video, url_prefix="/video")
app.register_blueprint(part, url_prefix="/part")


if __name__ == '__main__':
    app.run(debug=True, port=8000)