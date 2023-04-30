from flask import Blueprint, render_template

part = Blueprint(__name__, "video")

@part.route("/")
def components():
    return render_template("part.html")