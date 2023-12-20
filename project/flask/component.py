from flask import Blueprint, render_template

component = Blueprint(__name__, "component")

@component.route("/")
def components():
    return render_template("component.html")

@component.route("/motherboard")
def motherboard ():
    return render_template("motherboard.html")

@component.route("/cpu")
def cpu ():
    return render_template("cpu.html")

@component.route("/heatsync")
def heatsync ():
    return render_template("heatsync.html")

@component.route("/ram")
def ram ():
    return render_template("ram.html")

@component.route("/drive")
def drive ():
    return render_template("drive.html")

@component.route("/gpu")
def gpu ():
    return render_template("gpu.html")

@component.route("/psu")
def psu ():
    return render_template("psu.html")

