from flask import Blueprint, render_template

video = Blueprint(__name__, "video")

@video.route("/")
def components():
    return render_template("video.html")