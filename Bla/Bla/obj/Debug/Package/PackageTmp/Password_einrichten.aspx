<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Password_einrichten.aspx.cs" Inherits="Bla.Password_einrichten" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">
    <title>IMMUNO</title>
    <!-- Bootstrap core CSS-->
    <link rel="stylesheet" href="style/bootstrap.css">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.4.0/css/font-awesome.min.css">
    <link rel="stylesheet" href="style/login/bootstrap-theme.css">
    <link rel="stylesheet" href="style/login/style.css">
    <link rel="stylesheet" href="style/login/style-responsive.css">
</head>

<body class="login-img3-body">
<div class="container">
    <div class="text-left">
        <h4>
            <strong>Projektgruppe Universität Siegen</strong>
        </h4>
    </div>
    <div class="text-center">
        <h1>
            <strong>Immunologie</strong>
        </h1>
    </div>
    <form class=login-form action="Confirm.aspx">
        <div class="login-wrap">
            <div class="text-center">
                <h4><strong>Registrieren</strong>
                </h4>
            </div>
            <br>
            <div class="input-group" >
                <span class="input-group-addon">
                <input type="text" class="form-control" placeholder="Email Adresse eingeben" autofocus>
                </span>
            </div>
            <div class="input-group">
                <span class="input-group-addon">
                <input type="password" class="form-control" placeholder="Passwort">
                </span>
            </div>
            <div class="input-group">
                <span class="input-group-addon">
                <input type="password" class="form-control" placeholder="Passwort betätigen">
                </span>
            </div>
            <div class="input-group">
                <span class="input-group-addon">
                <input type="password" class="form-control" placeholder="Username bitte eingeben">
                </span>
            </div>
            <button class="btn btn-primary btn-lg btn-block" type="submit">Registrieren</button>
            <div class="text-center">
                <a class="d-block small" href="Login.aspx"><h5><strong>Abbrechnen</strong></h5></a>
            </div>
        </div>
        <br>
    </form>
</div>
<!-- Bootstrap core JavaScript-->
<script src="Scripts/bootstrap.bundle.min.js"></script>
<script src="Scripts/jquery.min.js"></script>
<script src="Scripts/jquery.easing.min.js"></script>
</body>
</html>
