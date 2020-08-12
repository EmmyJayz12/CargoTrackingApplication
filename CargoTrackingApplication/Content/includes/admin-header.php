
<!DOCTYPE html>

<head>
<meta charset="utf-8" />
<title>Delight Freight</title>
<meta content="width=device-width, initial-scale=1.0" name="viewport" />
<meta name="description"  content="Delight Freighto"/>
<meta name="keywords" content="Delight Freight, Transporting" />
<meta name="author"  content="Delight Freight"/>
<meta name="MobileOptimized" content="320" />

<!--srart theme style -->
<link href="../css/main.css" rel="stylesheet" type="text/css"/>
<!-- end theme style -->
<!-- favicon links -->
<link rel="shortcut icon" type="image/png" href="../images/header/lg7a.png" sizes="13x13"/>
<style>
     body{
       background-color: #DDD;
    }
    .adminsidebar {
       background-color: #666666;
         padding:1.2em;
    }
    .admincreateidbar{
     background-color: #eaebef;
	 color:rgb(0,0,0);
      padding:1.2em;
    }
    .admincreateidbar .createtrackid {
      background-color: rgb(255,255,255);
       padding:1.2em;
   }
   .error-detect {
       background-color: rgb(255,255,255);
       padding:1.2em;
   }
    .ed_bottompadder90 {
    padding-bottom: 0px;
}
.ed_toppadder90 {
    padding-top: 40px;
}
.content{
	margin-bottom: 2.0em;
}

.pro_menu ul li a:hover, .pro_menu ul li a::after{
	background-color:#fff !important;
	color:#000 !important;
}

    </style>
</head>
<body>
<!--Page main section start-->
<div id="pro_wrapper">
<!--Header start-->
<header id="ed_header_wrapper">
	<div class="ed_header_top">
		<div class="container">
			<div class="row">
				<div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
					<div class="pro_call">
						<!--<p>call now <i class="fa fa-volume-control-phone" aria-hidden="true"></i> +1 (205) 315-3435</p>-->
					</div>
				</div>
				<div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
					<div class="ed_info_wrapper">
						<ul>
							<li><a href="#" data-toggle="tooltip" data-placement="bottom" title="Facebook"><i class="fa fa-facebook" aria-hidden="true"></i></a></li>
							<li><a href="#" data-toggle="tooltip" data-placement="bottom" title="Google+"><i class="fa fa-google-plus" aria-hidden="true"></i></a></li>
							<li><a href="#" data-toggle="tooltip" data-placement="bottom" title="Twitter"><i class="fa fa-twitter" aria-hidden="true"></i></a></li>
							<li><a href="#" data-toggle="tooltip" data-placement="bottom" title="Linkedin"><i class="fa fa-linkedin" aria-hidden="true"></i></a></li>
						</ul>
					</div>
				</div>
			</div>
		</div>
	</div>
	<div class="ed_header_bottom">
		<div class="container">
			<div class="row">
				<div class="col-lg-3 col-md-3 col-sm-3">
					<div class="pro_logo"> <a href="#"><img src="../images/header/lg7a.png" style="width:40%;height:40%;" alt="logo" /></a> </div>
				</div>
				<div class="col-lg-9 col-md-9 col-sm-9">
					<div class="pro_menu_toggle navbar-toggle" data-toggle="collapse" data-target="#ed_menu">Menu <i class="fa fa-bars"></i>
					</div>
					<div class="pro_menu">
						<ul class="collapse navbar-collapse" id="ed_menu">
                                                    <li><a><span class="glyphicon glyphicon-user"></span><?php if(isset($_SESSION['id'])) echo $_SESSION['fname']; ?></a></li>
                                                    <li><a href="logout.php"><span class="glyphicon glyphicon-log-out"></span> Logout</a></li>
						</ul>
					</div>
				</div>
			</div>
		</div>
    </div>
</header>