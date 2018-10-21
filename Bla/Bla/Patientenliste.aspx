<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Patientenliste.aspx.cs" Inherits="Bla.Patienten_Liste" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">
    <title>IMMUNO</title>
    <link rel="stylesheet" href="style/bootstrap.css">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.4.0/css/font-awesome.min.css">
    <link rel="stylesheet" href="style/sb.admin.css">
    <link rel="stylesheet" href="style/calendar style/adminlte.css">
    <link rel="stylesheet" href="style/dataTables.bootstrap4.css">
</head>

<body class="fixed-nav sticky-footer bg-dark" id="page-top">
<!-- Navigation-->
<nav class="navbar navbar-expand-lg navbar-dark bg-dark fixed-top" id="mainNav">
    <a class="navbar-brand" href="Patientenliste.aspx"> IMMUNO</a>
    <button class="navbar-toggler navbar-toggler-right" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarResponsive">
        <ul class="navbar-nav navbar-sidenav" id="exampleAccordion">
            <li class="nav-item" data-toggle="tooltip" data-placement="right" title="Patientenliste">
                <a class="nav-link" href="Patientenliste.aspx">
                    <i class="fa fa-fw fa-group"></i>
                    <span class="nav-link-text">Patientenliste</span>
                </a>
            </li>
            <li class="nav-item" data-toggle="tooltip" data-placement="right" title="Medikamentendatenbank">
                <a class="nav-link" href="medicament.aspx">
                    <i class="fa fa-fw fa-medkit"></i>
                    <span class="nav-link-text">Medikamentendatenbank</span>
                </a>
            </li>
            <li class="nav-item" data-toggle="tooltip" data-placement="right" title="Terminverwaltung">
                <a class="nav-link" href="Terminverwaltung.aspx">
                    <i class="fa fa-fw fa-calendar"></i>
                    <span class="nav-link-text">Terminverwaltung</span>
                </a>
            </li>
            <li class="nav-item" data-toggle="tooltip" data-placement="right" title="Kontakt">
                <a class="nav-link nav-link-collapse collapsed" data-toggle="collapse" href="#collapseExamplePages" data-parent="#exampleAccordion">
                    <i class="fa fa-fw fa-send"></i>
                    <span class="nav-link-text">Nachricht</span>
                </a>
                <ul class="sidenav-second-level collapse" id="collapseExamplePages">
                    <li>
                        <a href="Broadcast.aspx">Broadcast</a>
                    </li>
                    <li>
                        <a href="unicast.aspx">Unicast</a>
                    </li>
                    <li>
                        <a href="rezept-send.aspx">Rezept senden</a>
                    </li>
                </ul>
            </li>
            <li class="nav-item" data-toggle="tooltip" data-placement="right" title="Neue Info">
                <a class="nav-link" href="Neue%20Info.aspx">
                    <i class="fa fa-fw fa-bullhorn"></i>
                    <span class="nav-link-text">Neue Informationen</span>
                </a>
            </li>
        </ul>
        <ul class="navbar-nav sidenav-toggler">
            <li class="nav-item">
                <a class="nav-link text-center" id="sidenavToggler">
                    <i class="fa fa-fw fa-angle-left"></i>
                </a>
            </li>
        </ul>
        <ul class="navbar-nav ml-auto">
            <li class="nav-item dropdown">
                <a class="nav-link dropdown-toggle mr-lg-2" id="alertsDropdown" href="#" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                    <i class="fa fa-fw fa-user"></i>
                </a>
                <div class="dropdown-menu" aria-labelledby="alertsDropdown">
                    <a class="dropdown-item" href="#">
                        <span class="text-success"> </i> Profil bearbeiten </span>
                    </a>
                    <div class="dropdown-divider"></div>
                    <a class="dropdown-item" href="#">
                        <span class="text-danger"></i> Profil löschen</span>
                    </a>
                </div>
            </li>
            <li class="nav-item">
                <form class="form-inline my-2 my-lg-0 mr-lg-2">
                    <div class="input-group">
                        <input class="form-control" type="text" placeholder="Suchen nach...">
                        <span class="input-group-append">
                <button class="btn btn-primary" type="button">
                  <i class="fa fa-search"></i>
                </button>
              </span>
                    </div>
                </form>
            </li>
            <li class="nav-item">
                <a class="nav-link" data-toggle="modal" data-target="#exampleModal">
                    <i class="fa fa-fw fa-sign-out"></i>Abmelden</a>
            </li>
        </ul>
    </div>
</nav>
<form runat="server">
<div class="content-wrapper">
    <div class="container-fluid">
        <div class="row">
            <div class="col-12">
                <h1>Patientenliste</h1>
            </div>
        </div>
    </div>
    <section class="content">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-12">
                    <div class="card card-primary card-outline">
                        <div class="card-body">
                            <div class="table-responsive">
                                <table class="table table-bordered" id="dataTable" width="100%" cellspacing="0" runat="server">
                                    <thead>
                                    <tr>
                                        <th><h6>ID-Nummer</h6></th>
                                        <th><h6>Name</h6></th>
                                        <th><h6>Geburtsdatum</h6></th>
                                        <th><h6>Telefonnummer</h6></th>
                                        <th><h6>Adresse</h6></th>
                                        <th><h6>Übersicht</h6></th>
                                        <th><h6>Doku 1</h6></th>
                                        <th><h6>Doku 2</h6></th>
                                    </tr>
                                    </thead>
                                    <tbody>
                                    <tr>
                                        <td>12345</td>
                                        <td>Name F</td>
                                        <td>03.01.2000</td>
                                        <td>545454545</td>
                                        <td>Siegen</td>
                                        <td>
                                            <a href="Detail.aspx" class="btn btn-primary btn-block">Detail</a>
                                        </td>
                                        <td>
                                            <a href="Arztseite.aspx" class="btn btn-primary btn-block ">Arztseite</a>
                                        </td>
                                        <td>
                                            <a href="Patientenseite.aspx" class="btn btn-primary btn-block">Patientenseite</a>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>32454</td>
                                        <td>Name A</td>
                                        <td>03.01.2018</td>
                                        <td>545454545</td>
                                        <td>Siegen</td>
                                        <td>
                                            <a href="Detail.aspx" class="btn btn-primary btn-block">Detail</a>
                                        </td>
                                        <td>
                                            <a href="Arztseite.aspx" class="btn btn-primary btn-block">Arztseite</a>
                                        </td>
                                        <td>
                                            <a href="Patientenseite.aspx" class="btn btn-primary btn-block">Patientenseite</a>
                                        </td>
                                    </tr>
                                    </tbody>
                                </table>
                            </div>
                            <div class="card-footer small text-muted">Updated gestern um 11:59 PM</div>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </section>
    <footer class="sticky-footer">
        <div class="container">
            <div class="text-center">
                <small>IMMUNO 2018 - Siegen</small>
            </div>
        </div>
    </footer>
    <!-- Scroll to Top Button-->
    <a class="scroll-to-top rounded" href="#page-top">
        <i class="fa fa-angle-up"></i>
    </a>
    <!-- Logout Modal-->
    <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Wollen sie sich wirklich abmelden?</h5>
                    <button class="close" type="button" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">×</span>
                    </button>
                </div>
                <div class="modal-footer">
                    <button class="btn btn-secondary" type="button" data-dismiss="modal">Abbrechen</button>
                    <a class="btn btn-primary" href="login.aspx">Abmelden</a>
                </div>
            </div>
        </div>
    </div>
    <!-- Bootstrap core JavaScript-->
    <script src="Scripts/jquery.min.js"></script>
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/jquery.easing.min.js"></script>
    <script src="Scripts/jquery.dataTables.js"></script>
    <script src="Scripts/dataTables.bootstrap4.js"></script>
    <script src="Scripts/sb-admin-datatables.min.js"></script>
    <script src="Scripts/sb-admin.min.js"></script>
</div>
</form>fform
</body>
</html>
