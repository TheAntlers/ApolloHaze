/********************* RedactHaze **********************

Original design: apopagasm
Original CSS: Exanurous
This stylesheet is derived from Gazelle Postmod.

Similar ports are available on other sites under different names  (Haze, Beluga, ...)

High-DPI images: Phlo

*******************************************************/

@import url(https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,bold);

* {
    padding: 0;
    margin: 0;
}
html {
    width: 100%;
}
body {
    background-image: url('https://media.giphy.com/media/grxBXF3i3NyjS/giphy.gif');
    background-repeat: no-repeat;
    -webkit-background-size: cover;
    -moz-background-size: cover;
    -o-background-size: cover;
    background-size: cover;
    background-attachment: fixed;
    background-position: center center;
    background-color: #212121;
    font-family: 'Source Sans Pro', Helvetica, Arial, sans-serif;
    font-size: 12px;
    font-weight: 400;
    color: #fff;
}
.forum_post pre {
    max-width: 660px;
    max-height: 500px;
    overflow: auto;
}
table tbody, .main_column, .sidebar, .box, .thin, .pad, #threadpoll, #poll {
    color: #fff;
}
h1, h2, h3, h4 {
    font-weight: 400;
}
h2 {
    font-size: 18px !important;
    text-shadow: 0 0 15px rgba(0, 0, 0, 0.1);
}
h2 a {
    color: rgba(255, 255, 255, 0.6);
    text-shadow: 0 0 15px rgba(0, 0, 0, 0.1);
}
a {
    text-decoration: none;
    border: none;
    color: rgba(255, 255, 255, 0.6);
}
a:hover {
    color: #02c2f2;
}
a img {
    border: 0;
}
table tbody a, .main_column a, .sidebar a, .box a {
    color: rgba(255, 255, 255, 0.6);
}
table tbody a:hover, .main_column a:hover, .sidebar a:hover, .box a:hover {
    color: #02c2f2;
}
a[onclick]:focus {
    outline: 0;
    background: transparent;
}
a[onclick]:active {
    outline: 0;
}
a[onclick^='AddArtistField']:focus, a[onclick^='AddArtistField']:active {
    outline: 0;
    background: transparent !important;
    padding: 0 !important;
}
h1, h2, h3 {
    margin: 5px 0;
    color: #fff;
}
.box h1, .box h2, .box h3, .box h4 .box2 h1, .box2 h2, .box2 h3, .box2 h4 {
    color: #fff;
}
li {
    margin: 5px 15px;
}
input {
    padding: 2px 3px;
}
textarea {
    padding: 2px 3px;
    font-family: 'Source Sans Pro', Helvetica, Arial, sans-serif;
    font-size: 13px;
    background: rgba(0, 0, 0, 0.32);
    border: 1px solid rgba(255, 255, 255, 0.08);
    color: #fff;
}
textarea:hover, textarea:active, textarea:focus {
    background: rgba(0, 0, 0, 0.42);
    border: 1px solid rgba(255, 255, 255, 0.1);
    outline: none;
}
img {
    border: none;
}
strong, b {
    font-weight: 700 !important;
}
.head .time {
    margin-left: 5px;
    color: rgba(255, 255, 255, 0.5);
}
::selection {
    background: rgba(255, 255, 255, 0.4);
}
::-moz-selection {
    background: rgba(255, 255, 255, 0.4);
}
span.size1 {
    font-size: .75em;
}
span.size2 {
    font-size: 1em;
}
span.size3 {
    font-size: 1.25em;
}
span.size4 {
    font-size: 1.5em;
}
span.size5 {
    font-size: 1.75em;
}
span.size6 {
    font-size: 2em;
}
span.size7 {
    font-size: 2.25em;
}
span.size8 {
    font-size: 2.5em;
}
span.size9 {
    font-size: 2.75em;
}
span.size10 {
    font-size: 3em;
}
ul.thin {
    margin: 0 0 0 25px;
    padding: 0;
}
ul.thin li {
    margin: 0 0;
    padding: 0;
}
.r00 {
    color: #e90c53;
}
.r01 {
    color: #f91c44;
}
.r02 {
    color: #ff3a3a;
}
.r03 {
    color: #fd632a;
}
.r04 {
    color: #ff7f30;
}
.r05 {
    color: #ff992f;
}
.r06 {
    color: #ffaf31;
}
.r07 {
    color: #ffc332;
}
.r08 {
    color: #ffd234;
}
.r09 {
    color: #ffdf35;
}
.r10 {
    color: #44c00f;
}
.r20 {
    color: #5dcf26;
}
.r50 {
    color: #83e84c;
}
.r99 {
    color: #a1fb69;
}
#wrapper {
    padding: 0 0 0 0;
}
#header {
    width: 900px;
    margin: 0 auto 0 auto;
    padding: 0 0 0 0;
}
#content {
    width: 900px;
    margin: 0 auto 0 auto;
    overflow: hidden;
}
#footer {
    margin-top: 40px;
    width: 100%;
    text-align: center;
    padding: 1em 0;
    color: rgba(255, 255, 255, 0.6);
    font-size: 10px;
}
#disclaimer_container {
    font-size: 9px;
    color: rgba(255, 255, 255, 0.6);
}
#logo {
    width: auto;
    height: 80px;
    z-index: 2;
    margin-top: 15px;
    margin-bottom: 30px
}
#logo a {
    border: none;
    width: auto;
    height: 80px;
    background: url('https://ptpimg.me/qf4hw8.png') no-repeat top left;
    background-size: auto 80px;
    display: block;
    margin-left: 0;
}

#header a:active, #header a:focus, #logo a:hover, #logo a:active, logo a:focus {
    border: none;
    outline: none;
}
#menu {
    margin-bottom: 2px;
    height: 50px;
}
#menu a {
    display: inline-block;
    -moz-box-sizing: border-box;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    height: 50px !important;
    line-height: 50px !important;
    text-align: center;
    vertical-align: middle;
    color: #fff;
    text-transform: uppercase;
    text-decoration: none;
}
#menu a:hover {
    color: #000;
    background: #fff !important;
    border: solid rgba(0, 0, 0, 0) !important;
    border-width: 1px 0 !important;
    font-weight: 400;
    transition: color 0.4s;
}
#menu a:active {
    background: #f3f3f3 !important;
}
#menu li:nth-child(2) a {
    background: linear-gradient(rgba(0, 0, 0, 0.6),  rgba(0, 0, 0, 0.62));
    width: 100px;
    border: solid rgba(0, 0, 0, 0.1);
    border-width: 1px 0 1px 1px;
}
#menu li:nth-child(3) a {
    background: linear-gradient(rgba(0, 0, 0, 0.54),  rgba(0, 0, 0, 0.56));
    width: 100px;
    border: solid rgba(0, 0, 0, 0.1);
    border-width: 1px 0;
}
#menu li:nth-child(4) a {
    background: linear-gradient(rgba(0, 0, 0, 0.48),  rgba(0, 0, 0, 0.5));
    width: 100px;
    border: solid rgba(0, 0, 0, 0.1);
    border-width: 1px 0;
}
#menu li:nth-child(5) a {
    background: linear-gradient(rgba(0, 0, 0, 0.42),  rgba(0, 0, 0, 0.44));
    width: 92px;
    border: solid rgba(0, 0, 0, 0.1);
    border-width: 1px 0;
}
#menu li:nth-child(6) a {
    background: linear-gradient(rgba(0, 0, 0, 0.36),  rgba(0, 0, 0, 0.38));
    width: 66px;
    border: solid rgba(0, 0, 0, 0.1);
    border-width: 1px 0;
}
#menu li:nth-child(7) a {
    background: linear-gradient(rgba(0, 0, 0, 0.3),  rgba(0, 0, 0, 0.32));
    width: 88px;
    border: solid rgba(0, 0, 0, 0.1);
    border-width: 1px 0;
}
#menu li:nth-child(8) a {
    background: linear-gradient(rgba(0, 0, 0, 0.24),  rgba(0, 0, 0, 0.26));
    width: 88px;
    border: solid rgba(0, 0, 0, 0.08);
    border-width: 1px 0;
}
#menu li:nth-child(9) a {
    background: linear-gradient(rgba(0, 0, 0, 0.18),  rgba(0, 0, 0, 0.2));
    width: 88px;
    border: solid rgba(0, 0, 0, 0.08);
    border-width: 1px 0;
}
#menu ul {
    margin: 0;
    padding: 0;
    list-style: none;
}
#menu ul li {
    float: left;
    margin: 0;
    display: block;
}
#nav_index {
    display: none !important;
}
#nav_Free a {
    position: relative;
    top: -133px;
    right: 60px;
    background: url('./images/menu/freeleech-sprite-dark.png');
    background-position: 0 8px !important;
    background-repeat: no-repeat;
    background-size: 50px auto !important;
    padding: 35px 0px 0px 0px !important;
    color: transparent !important;
    display: block;
    width: 50px;
    margin-top: 0;
    font-weight: 700 !important;
    font-size: 0.8em;
    text-align: center;
    transition: color 0.2s;
}
#nav_Free a:hover {
    background: url('./images/menu/freeleech-sprite-dark.png') !important;
    background-position: 0 91px !important;
    background-size: 50px auto !important;
    color: #fff !important;
}
#nav_Free a:active {
    background: url('./images/menu/freeleech-sprite-dark.png') !important;
    background-position: 0 49px !important;
    background-size: 50px auto !important;
    color: #fff !important;
}
#nav_staff {
    position: absolute;
    display: inline-block;
    -moz-box-sizing: border-box;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    width: 0px;
    height: 42px;
    color: transparent;
 
    margin: -133px 0 0 713px !important;
}

















#nav_bonus{
    display: inline-block;
    -moz-box-sizing: border-box;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    width: 50px;
    height: 42px;
    color: transparent;
    margin: -133px 0 0 713px !important;
}
#nav_bonus a {
    color: transparent;
    display: block;
    width: 50px;
    margin-top: 0;
    padding-top: 45px;
    font-weight: 700 !important;
    font-size: 10px;
    text-align: center;
    background: url('https://ptpimg.me/o6nxj7.png');
    background-position: 0 3px;
    background-size: 50px auto !important;
    transition: color 0.2s;
}
#nav_bonus a:hover {
    color: #fff;
    background: url('https://ptpimg.me/o6nxj7.png') !important;
    background-position: 0 87px !important;
    background-size: 50px auto !important;
}
#nav_bonus a:active {
    color: #fff;
    background: url('https://ptpimg.me/o6nxj7.png');
    background-position: 0 45px !important;
    background-size: 50px auto !important;
}


































#nav_staff a {
    color: transparent;
    display: block;
    position:absolute;
    right:-20px;
    width: 50px;
    margin-top: 0;
    padding-top: 35px;https://apollo.rip/staff.php
    font-weight: 700 !important;
    font-size: 10px;
    text-align: center;
    background: url('./images/menu/staff-sprite-dark.png');
    background-position: 0 8px;
    background-size: 50px auto !important;
    transition: color 0.2s;
}
#nav_staff a:hover {
    color: #fff;
    background: url('./images/menu/staff-sprite-dark.png') !important;
    background-position: 0 91px !important;
    background-size: 50px auto !important;
}
#nav_staff a:active {
    color: #fff;
    background: url('./images/menu/staff-sprite-dark.png');
    background-position: 0 49px !important;
    background-size: 50px auto !important;
}
#userinfo {
    position: relative;
    color: #182029;
    width: 100%;
    text-transform: uppercase;
    list-style: none;
}
#userinfo_major {
    position: absolute;
    -moz-box-sizing: border-box;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    margin: -131px 0 0 765px;
    float: right;
    white-space: nowrap;
    right:-30px;
}
#userinfo_major li a {
    display: inline-block;
    -moz-box-sizing: border-box;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    width: 50px;
    height: 42px;
    color: transparent;
}
#userinfo_major li {
    margin: 0 0 0 -2px !important;
}
#userinfo_major #nav_invite a, #userinfo_major #nav_upload a, #userinfo_major #nav_donate a, #userinfo_major #nav_store a {
    color: transparent;
    display: block;
    width: 50px;
    margin-top: 0;
    padding-top: 48px;
    font-weight: 700;
    font-size: 10px;
    text-align: center;
    transition: color 0.2s;
}
#userinfo_major #nav_upload {
    background: url('./images/menu/upload-sprite-dark.png');
    background-position: 0px 6px;
    background-size: 50px auto !important;
}
#userinfo_major #nav_upload a:hover {
    color: #fff;
    background: url('./images/menu/upload-sprite-dark.png');
    background-position: 0 90px;
    background-size: 50px auto !important;
}
#userinfo_major #nav_upload a:active {
    color: #fff;
    background: url('./images/menu/upload-sprite-dark.png');
    background-position: 0 48px;
    background-size: 50px auto !important;
}
#userinfo_major #nav_invite {
    background: url('./images/menu/invite-sprite-dark.png');
    background-position: 0px 6px;
    background-size: 50px auto !important;
}
#userinfo_major #nav_invite a:hover {
    color: #fff;
    background: url('./images/menu/invite-sprite-dark.png');
    background-position: 0 90px;
    background-size: 50px auto !important;
}
#userinfo_major #nav_invite a:active {
    color: #fff;
    background: url('./images/menu/invite-sprite-dark.png');
    background-position: 0 49px;
    background-size: 50px auto !important;
}
#userinfo_major #nav_donate {
    background: url('./images/menu/donate-sprite-dark.png');
    background-position: 0px 6px;
    background-size: 50px auto !important;
}
#userinfo_major #nav_donate a:hover {
    color: #fff;
    background: url('./images/menu/donate-sprite-dark.png');
    background-position: 0 90px;
    background-size: 50px auto !important;
}
#userinfo_major #nav_donate a:active {
    color: #fff;
    background: url('./images/menu/donate-sprite-dark.png');
    background-position: 0 48px;
    background-size: 50px auto !important;
}

#extra2 {
	position: fixed;
	background-color: rgba(53, 54, 54, 0.97);
	width: 984px;
  	top:0px; bottom:0; left:0; right:0;
	margin:0px auto;
	z-index:-2;
}
#userinfo_stats {
    color: #fff;
    font-weight: 400;
    text-shadow: 0 0 15px rgba(0, 0, 0, 0.1);
    line-height: 58px;
    vertical-align: middle;
    float: right;
    display: inline-block;
    width: auto;
    margin-top: -68px;
    margin-right: 0;
}
#userinfo_stats a {
    color: rgba(255, 255, 255, 0.8) !important;
}
#userinfo_stats a:hover {
    color: #fff !important;
}
#userinfo_username {
    position: absolute;
    list-style: none;
    margin: 4px 0 0 0;
    right: 0;
    z-index: 999;
}
#userinfo_username li:first-child a {
    -moz-box-sizing: border-box;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    width: 130px !important;
    height: 50px !important;
    line-height: 50px !important;
    vertical-align: middle;
    color: #fff;
    text-align: center;
    border: solid rgba(0, 0, 0, 0.08);
    border-width: 1px 0;
    background: linear-gradient(rgba(0, 0, 0, 0.12),  rgba(0, 0, 0, 0.14));
    padding: 0 !important;
    display: block;
    position: relative;
    margin: -4px 0 0 0 !important;
    visibility: visible;
}
#userinfo_username li:first-child {
    display: block;
    width: 128px !important;
    color: #000 !important;
}
#userinfo_username li:first-child a:hover {
    background: #fff;
    color: #000;
    border: none !important;
}
#userinfo_username:hover li:first-child a {
    border-bottom: 1px solid rgba(0, 0, 0, 0.1) !important;
}
#userinfo_username li:first-child a:active {
    background: #f3f3f3;
}
#userinfo_username:hover li:first-child a {
    border: none;
}
#userinfo_username:hover {
    font-weight: 400;
}
#userinfo_username li a {
    -moz-box-sizing: border-box;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    width: 178px;
    height: 0px;
    line-height: 36px;
    vertical-align: middle;
    display: block;
    padding: 0 12px;
    background: #fff;
    color: #000;
    margin: -4px 0 0 0 !important;
    visibility: hidden;
}
#userinfo_username li:nth-child(3) a {
    margin-top: 0 !important;
}
#userinfo_username:hover li a, #userinfo_username:active li a {
    background: #fff;
    color: #000;
    text-decoration: none;
    visibility: visible;
    height: 36px;
    transition: height 0.1s ease-out 0.15s, visibility 0 ease-out 0.17s, color 0.4s;
    -webkit-transition: height 0.1s ease-out 0.15s, visibility 0 ease-out 0.17s, color 0.4s;
}
#userinfo_username li {
    display: block !important;
}
#userinfo_username li a:hover {
    background: #e5e5e5;
    text-decoration: none;
}
#userinfo_username li a:active {
    background: #dadada;
    text-decoration: none;
}
#userinfo .brackets:before, #userinfo .brackets:after {
    content: none !important;
}
#userinfo_username #nav_userclass {
    display: none;
}
#userinfo_minor:before {
    content: '';
    border: solid rgba(0, 0, 0, 0.08);
    border-width: 0 1px 0 0;
}
#userinfo_minor {
    position: absolute;
    display: block;
    list-style: none;
    right: 0px;
    top: 0px;
    z-index: 99999;
    width: 48px !important;
    height: 49px;
    line-height: 50px !important;
    border-top: 1px solid rgba(0, 0, 0, 0.1);
    background: url('./images/caret-light.png') center center no-repeat;
    background-color: rgba(0, 0, 0, 0.1);
    background-size:  30px auto;
}
#userinfo_minor:hover, #userinfo_minor:focus, #userinfo_minor:active {
    background-color: #fff;
    height: 48px !important;
    border-top: 1px solid rgba(255, 255, 255, 0);
    border-bottom: 1px solid rgba(0, 0, 0, 0.1);
    background: url('./images/caret-dark.png') center center no-repeat #fff;
    background-size:  30px auto;
    transition: background 0.4s;
}
#userinfo_minor li {
    margin: 0 0 0 -160px !important;
    display: block !important;
    visibility: hidden;
    height: 0;
}
#userinfo_minor:hover > li {
    visibility: visible;
    height: 36px;
    transition: height 0.1s ease-out 0.15s, visibility 0 ease-out 0.17s;
    -webkit-transition: height 0.1s ease-out 0.15s, visibility 0 ease-out 0.17s;
}
#userinfo_minor li a {
    display: block;
    -moz-box-sizing: border-box;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    vertical-align: middle;
    width: 178px;
    line-height: 36px;
    padding: 0 12px !important;
    background: #fff;
    color: #000;
    margin: -4px 0 0 30px !important;
}
#userinfo_minor li:first-child a {
    margin-top: 0 !important;
}
#userinfo_minor li a:hover {
    background: #e5e5e5;
    text-decoration: none;
}
#userinfo_minor li a:active {
    background: #dadada;
    text-decoration: none;
}
#userinfo ul li {
    display: inline-block;
    line-height: 20px;
    vertical-align: middle;
    margin: 0 0 0 6px;
}
#alerts a {
    color: #fff;
}
#alerts a:hover {
    text-decoration: underline;
}
#index #searchbars {
    margin-bottom: 2px !important;
}
#searchbars {
    width: 898px;
    height: 34px;
    padding: 8px 0;
    border: 1px solid rgba(0, 0, 0, 0.1);
    background: rgba(0, 0, 0, 0.1);
    background-image: url('./images/light-on-dark/search.png');
    background-repeat: no-repeat;
    background-position: 13px 14px;
    background-size: auto 22px;
    margin-bottom: 10px;
}
#searchbars input {
    -moz-box-sizing: border-box;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    width: 133.5px;
    height: 34px;
    margin: 0;
    padding: 11px 11px;
    background: rgba(0, 0, 0, 0.2);
    border: 1px solid rgba(0, 0, 0, 0.2);
    border-radius: 1px;
    color: #fff;
    font-family: 'Source Sans Pro', Helvetica, Arial, sans-serif;
    font-weight: 300;
    font-size: 12px !important;
}
::-webkit-input-placeholder {
    color: rgba(255, 255, 255, 0.5);
}
:-moz-placeholder {
    color: rgba(255, 255, 255, 0.5);
}
::-moz-placeholder {
    color: rgba(255, 255, 255, 0.5);
}
:-ms-input-placeholder {
    color: rgba(255, 255, 255, 0.5);
}
#searchbars input:hover, #searchbars input:active, #searchbars input:focus {
    background: rgba(0, 0, 0, 0.35);
    border: 1px solid rgba(0, 0, 0, 0.5);
    outline: none;
    transition: all 0.4s;
}
#searchbars ul {
    margin: 0;
    padding: 0;
    list-style: none;
    display: block;
}
#searchbars ul li {
    display: inline;
    float: left;
    margin: 0 7px 0 0;
    position: relative;
    list-style: none;
}
#searchbars ul li:first-child {
    margin-left: 46px;
}
#searchbars ul li form {
    display: inline;
    margin: 0;
}
.autocomplete-suggestions {
    font-size: 12px;
    font-weight: 400 !important;
    width: initial !important;
    max-width: 300px !important;
    max-height: 720px !important;
    border: 1px rgba(38, 50, 64, 0.9);
    border-radius: 1px;
    margin-top: 0;
    border: none;
    background: rgba(59, 59, 59, 0.9);
    color: #fff;
}
.autocomplete-suggestion {
    padding: 8px 11px 8px 8px;
}
.autocomplete-selected {
    color: #3b3b3b;
    background: #fff;
}
.autocomplete-selected strong {
    font-weight: 400;
    color: rgba(59, 59, 59, 0.9) !important;
}
.autocomplete-suggestions strong {
    font-weight: 400;
    color: #01afd8;
}
#alerts {
    width: 900px;
    text-align: center;
    color: #fff;
}
#alerts .alertbar {
    -moz-box-sizing: border-box;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    border: 1px solid rgba(0, 0, 0, 0.1);
    height: 36px;
    line-height: 36px;
    vertical-align: center;
    margin-bottom: 2px;
    color: transparent;
    background: linear-gradient(rgba(0, 0, 0, 0.4),  rgba(0, 0, 0, 0.42));
}
#alerts .alertbar a {
    text-transform: uppercase;
}
#cat-selector ul {
    width: 100%}
#cat-selector ul li {
    display: inline;
    width: 12em;
    height: 1em;
    float: left;
}
#debug_report pre {
    width: 890px;
    overflow: auto;
}
td.cats_col, td.center.cats_col {
    border-right: none;
}
table.grouping>tbody>tr.torrent>td:first-child+td+td, table.no_grouping>tbody>tr.torrent>td:first-child+td, table.grouping>tbody>tr.group>td:first-child+td+td, table.grouping>tbody>tr.colhead>td:first-child+td+td, table.no_grouping>tbody>tr.group>td:first-child+td, table.no_grouping>tbody>tr.colhead>td:first-child+td {
    border-left: none;
}
.last_topic a {
    display: inline-block;
}
.last_read {
    width: 16px;
    height: 16px;
    background: url('./images/light-on-dark/forum/go_last_read.png') no-repeat center center;
    margin-left: 5px;
    background-size: 16px;
    opacity: 0.7;
    transition: opacity 0.2s;
}
.read_locked_sticky+td .last_read, .read_sticky+td .last_read, .read+td .last_read {
    opacity: 0.2;
    transition: opacity 0.2s;
}
.last_read a {
    border: none;
    width: 100%;
    height: 100%;
    display: block;
}
.last_read:hover, .read_locked_sticky+td .last_read:hover, .read_sticky+td .last_read:hover, .read+td .last_read:hover {
    border: none;
    opacity: 1;
    transition: opacity 0.2s;
}
.last_read a:active, .last_read a:focus {
    outline: 0;
    opacity: 1;
}
.hidden {
    position: absolute;
    left: -10000px;
}
input.hidden {
    position: absolute;
    display: none;
}
.thin {
    width: 900px;
    margin: 0 auto;
}
.thin h2 {
    font-weight: 600;
    margin: 0 20px 0 0;
}
.linkbox {
    text-align: right;
    padding: 10px 0;
    font-weight: 400;
    text-transform: uppercase;
}
.linkbox a {
    color: rgba(255, 255, 255, 0.6);
    text-shadow: 0 0 15px rgba(0, 0, 0, 0.2);
}
.linkbox a:hover {
    color: #01afd8;
}
.linkbox .brackets {
    margin-left: 10px;
}
.linkbox .brackets:before, .linkbox .brackets:after {
    display: none;
}
.donation_info_title {
    text-shadow: none;
}
.center {
    text-align: center;
}
.right {
    text-align: right;
}
.min_padding {
    padding: 0;
    margin: 0 0;
}
p.min_padding {
    margin: 2px 0;
}
.pad {
    padding: 12px;
}
.sidebar .pad {
    padding: 12px;
}
.vertical_space {
    margin-bottom: 10px;
}
.box {
    font-size: 13px;
    background: none;
    background-color: rgba(0, 0, 0, 0.2);
    margin-bottom: 2px;
    word-wrap: break-word;
}
.box2 {
    font-size: 13px;
    background: none;
    background-color: rgba(0, 0, 0, 0.2);
    margin-bottom: 2px;
}
.pad h3, .pad h4, .padbox h3, .padbox h4 {
    margin-top: 0;
    padding-top: 0;
}
.sidebar {
    float: right;
    width: 240px;
    font-weight: 300;
}
.sidebar .stats {
    padding: 5px 0;
}
.body {
    padding: 12px;
}
.main_column {
    width: 658px;
}
.main_column table {
    margin-bottom: 2px;
}
.main_column .box .body {
    font-size: 13px;
}
.main_column #recommended .head a[href='#']
{

    float: right;
}
.tags {
    padding: 0 0 0 20px;
    font-style: italic;
}
.tags a {
    color: rgba(255, 255, 255, 0.6) !important;
}
.tags a:hover {
    color: #02c2f2 !important;
}
.noborder {
    border: none;
}
ul.nobullet {
    list-style-type: none;
}
table {
    width: 100%;
    border-collapse: collapse;
    border: none;
}
tr {
    border: solid rgba(0, 0, 0, 0.1);
    border-width: 0 0 1px 0;
    background-color: rgba(0, 0, 0, 0.2);
}
tr.rowa {
    background-color: rgba(0, 0, 0, 0.1);
}
tr.rowb {
    background-color: rgba(0, 0, 0, 0.2);
}
td, th {
    border: none;
    padding: 5px;
    text-align: left;
}
#forums #reply_box h3 {
    margin: 20px 0 0 0;
}
#forums #newthreadtext tr {
    background: none;
    border: none;
}
#reply_box h3 {
    margin: 0;
}
#inbox h3 {
    margin: 2px 0 0 0;
}
#inbox .send_form .box {
    background-color: rgba(0, 0, 0, 0.2);
}
#inbox .send_form .box #quickpost {
    width: 868px;
    margin-bottom: 10px;
}
#inbox input[value='Editor']
{
    margin-right: 3px;
}
#content>div>form.manage_form>div>table>tbody>tr {
    border: none;
    background: none;
}
.head, #reply_box h3, #inbox h3, #discog_table>.box.center, .colhead, .colhead_dark {
    padding: 12px;
    background: linear-gradient(rgba(0, 0, 0, 0.4),  rgba(0, 0, 0, 0.48));
    color: #fff !important;
    text-transform: uppercase;
    border: 1px rgba(0, 0, 0, 0.1);
    border-radius: 1px;
    box-shadow: 0 1px 3px 0 rgba(0, 0, 0, 0.05);
    font-size: 12px;
    font-weight: 400 !important;
}
.filelist_path {
    text-transform: initial;
}
.head .brackets:before, .head .brackets:after {
    content: none !important;
}
.head .brackets {
    color: rgba(255, 255, 255, 0.5);
}
.colhead a, .colhead_dark a, .head a, #discog_table>.box.center a {
    color: rgba(255, 255, 255, 0.5) !important;
}
.colhead_dark a img:active, .colhead_dark a img:focus {
    outline: 0;
}
td.colhead, .colhead td, td.colhead_dark, .colhead_dark td, .colhead th {
    padding: 12px 5px;
}
#forums tr.colhead td[style='width: 7%;']
{
    text-align: right;
}
.colhead .sign, .colhead_dark .sign {
    padding: 0 8px;
    vertical-align: middle;
    text-align: center;
    font-size: 12px;
    font-weight: 400 !important;
}
td.label {
    text-align: right;
    width: 180px;
    vertical-align: middle;
}
table.slice {
    margin-top: -1px;
}
tr.peer_list {
    font-size: 12px;
}
tr.peer_list td {
    padding: 2px 0 2px 2px;
}
.error_message {
    border: 1px solid #666;
    padding: 3px 0 3px 0;
    background-color: #af2405;
    text-align: center;
    color: #fff;
}
.save_message {
    border: 1px solid rgba(255, 255, 255, 0.4);
    padding: 3px 0;
    background-color: rgba(255, 255, 255, 0.6);
    font-weight: 400;
    text-align: center;
    color: #000;
}
.elem_error {
    border: 3px solid #b00d0d;
}
.hide {
    display: none;
}
ul.stats li {
    padding: 3px 0;
    font-size: 12px;
    margin: 0 15px;
}
ul.poll li {
    padding: 0 0 0 10px;
    margin: 0;
    clear: left;
}
ul.poll li.graph {
    margin-bottom: 3px;
    padding-left: 20px;
}
.show_torrents {
    width: 28px;
    height: 28px;
    background: url('./images/light-on-dark/show.png') no-repeat center center;
    background-size:10px;
}
.hide_torrents {
    width: 28px;
    height: 28px;
    background: url('./images/light-on-dark/hide.png') no-repeat center center;
    background-size:10px;
}
.show_torrents_link {
    border: none;
    width: 28px;
    height: 28px;
    display: block;
}
.torrent_label {
    color: #01afd8;
}
.torrent_table a:active img, .torrent_table a:focus img {
    background-color: transparent !important;
}
.torrent_table .number_column {
    padding: 5px 8px;
}
.torrent_table.grouped.release_table>tbody>tr.colhead_dark>td:nth-child(3), #torrent_details>tbody>tr.colhead_dark>td:nth-child(2) {
    text-align: center;
}
.filter_torrents {
    width: 900px;
    margin: auto;
}
.filter_torrents .submit {
    text-align: right;
    padding-top: 5px;
}
.filter_torrents #ft_container tr {
    background: none;
}
#content form.search_form+.torrent_table {
    margin-top: 20px;
}
.cat_list tr td {
    border: none;
}
.torrent_table tr {
    vertical-align: top;
}
.torrent_table a, .collage_table a {
    color: #fff;
}
.torrent_table a:hover, .collage_table a:hover {
    text-decoration: none;
}
.collage_table tr {
    background-color: rgba(255, 255, 255, 0.05);
}
.torrent_table tr.group {
    background-color: rgba(0, 0, 0, 0.1);
    border: none;
}
.torrent_table tr.group_torrent {
    background-color: rgba(255, 255, 255, 0.05);
}
tr.group_torrent td, tr.group td, tr.torrent td {
    color: #fff;
}
.torrent_table tr .center {
    vertical-align: middle;
    text-align: center;
}
.torrent_table tr.colhead_dark>td.number_column {
    vertical-align: middle;
}
.group_torrent span {
    float: left;
}
.group_torrent span a {
    color: #c3c0c0;
}
#torrents .group_torrent span:after {
    content: '.';
    visibility: hidden;
}
#torrents form.search_form>div.submit {
    background-color: rgba(0,0,0,0.15);
    padding: 10px 0;
    text-align: center;
}
.torrent span {
    font-weight: normal;
    float: right;
}
.torrent_row * img {
    max-width: 500px;
    float: left;
}
.nobr {
    white-space: nowrap;
}
.add_form[name='artists']
{
    -moz-box-sizing: border-box;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    width: 232px;
}
.add_form[name='artists'] input, .add_form[name='artists'] select {
    width: 93%;
    margin: 2px 0 !important;
}
#top10 .header h2, #requests .header h2, #userhistory .header h2, #inbox .header h2, #inbox .thin>h2, #user .header h2, #bookmarks .header h2, #artist .header h2, #forums .thin>h2, #collage .header h2, #wiki .header h2 {
    float: left;
}
#requests .thin>.box, #inbox #messageform, #user #userform, #user .thin>.box, #artist .thin>.box, #artist .thin>table, #forums .forum_list, #forums .thin>.box, #wiki .thin>table, #wiki .thin>form, #collage .thin .search_form, #collage .thin>table, #collage .thin .edit_form {
    clear: both;
}
#wiki input[maxlength='100'], #wiki textarea[rows='22'], .forum_post form textarea {
    width: 100%}
#forums .linkbox .center {
    text-align: right;
    margin-bottom: 10px;
}
.important_user .colhead_dark td>div:nth-child(1) {
    background-image: url('./images/light-on-dark/forum/op.png');
    background-repeat: no-repeat;
    background-size: 20px;
    padding-left: 25px;
    background-position: center left;
}
.forum_unread {
    border-left: 2px solid #0bb9e6 !important;
    border-width: 0 0 0 2px;
}
.forum_post a {
    word-break: break-all;
}
.forum_post>tbody>tr+tr {
    border: none;
}
.forum_post>tbody>tr:first-child>td>div+div input[type='button']
{
    margin-left: 2px;
}
.unread_sticky, .read_sticky, .unread_locked_sticky, .read_locked_sticky {
    background: url('./images/light-on-dark/forum/pin.png') no-repeat center center;
    background-size: 100%;
}
.unread_locked, .read_locked {
    background: url('./images/light-on-dark/forum/lock.png') no-repeat center center;
    background-size: 75%;
}
.unread, .read {
    background: url('./images/light-on-dark/forum/bubble.png') no-repeat center center;
    background-size: 85%;    
}
.unread_sticky, .unread_locked, .unread, .unread_locked_sticky {
    opacity: 1;
}
.read_sticky, .read_locked, .read, .read_locked_sticky {
    opacity: 0.3;
}
.unread:after, .unread_locked:after {
    content: '';
    position: relative;
    display: block;
    top: 4px;
    left: 7px;
    height: 8px;
    width: 8px;
    box-sizing: border-box;
    -moz-box-sizing: border-box;
    -webkit-box-sizing: border-box;
    background-color: #0bb9e6;
    border-radius: 10px;
    border: 1.5px solid rgba(0, 0, 0, 0.2);
}
.unread_locked_sticky:after, .read_locked_sticky:after {
    content: '';
    position: relative;
    display: block;
    top: 4px;
    left: 6px;
    height: 10px;
    width: 10px;
    background: url('./images/light-on-dark/forum/lock.png') no-repeat center center;
    background-size: 100%;
}table.forum_post {
    margin: 2px 0;
}
table.forum_post td {
    border: none;
}
table.forum_post .colhead_dark {
    text-transform: none;
}
table.forum_post .colhead_dark strong a {
    color: #fff;
}
td.avatar {
    width: 150px;
    padding: 0;
}
table.forum_post td.body {
    width: 690px;
}
#quickreplypreview .forum_post {
    padding: 5px;
}
strong.quoteheader {
    color: #fff;
}
blockquote, code {
    margin: 10px;
    padding: 10px;
    border: 1px solid rgba(255, 255, 255, 0.15);
    background: rgba(255, 255, 255, 0.08);
}
code {
    font-family: 'DejaVu Sans Mono', monospace;
    font-size: 12px;
    margin: 0;
    padding: 3px;
    white-space: pre-wrap;
    white-space: -moz-pre-wrap;
    white-space: -pre-wrap;
    white-space: -o-pre-wrap;
    line-height: 15px;
    display: inline-block;
}
#reply_box .box {
    background-color: rgba(0,0,0,0.15);
}
tr.unreadpm {
    background-color: #68b85c !important;
}
tr.unreadpm a:hover {
    color: #90ff80 !important;
}
#inbox .head {
    text-transform: none;
}
#inbox .send_form#messageform #quickpost input[name='subject']
{
    width: 100%;
    margin: 2px 0 0 0;
}
#inbox .send_form#messageform #quickpost textarea {
    width: 860px;
    margin: 2px 0 0 0;
}
#inbox .search_form#searchbox input[name='search']
{
    margin: 10px 0 0 0;
    width: 100% !important;
}
#inbox #messageform input[type='submit']
{
    margin-top: 10px;
}
#inbox .message_table.checkboxes {
    margin-top: 10px;
}
#inbox .message_table.checkboxes td[width='10']
{
    padding: 12px 7px;
}
#friends input[type='submit']
{
    margin-bottom: 4px;
}
#friends .left {
    text-align: right;
    vertical-align: middle !important;
}
#friends textarea {
    width: 100%;
    height: 100%}
#friends .thin>.box.pad {
    background: none;
}
#friends .thin>.box.pad .manage_form {
    width: 900px;
    margin-left: -12px;
}
ul.collage_images {
    width: 658px;
}
ul.collage_images li {
    vertical-align: middle;
    border: none;
    float: left;
    margin: 0;
    width: 132px;
    height: 129px;
    list-style: none;
    list-style-type: none;
}
ul.collage_images li a {
    display: block;
    height: 129px;
    overflow: hidden;
}
ul.collage_images img {
    height: 129px;
    width: 132px;
}
ul.collage_images li:nth-child(5n) {
    height: 129px;
    width: 130px;
}
ul.collage_images li:nth-child(5n) img {
    height: 129px;
    width: 130px;
}
.permission_head {
    width: 400px;
    margin-left: auto;
    margin-right: auto;
}
.permissions {
    width: 930px;
    margin-left: auto;
    margin-right: auto;
}
.permission_container {
    float: left;
    width: 300px;
    padding: 5px;
}
.permission_container input {
    margin: 0 3px 5px 0;
    vertical-align: top;
}
.submit_container {
    clear: both;
    text-align: right;
}
#upload #content>div.box.pad[style='margin: 0px auto; width: 700px;']
{
    width: 876px !important;
    margin-bottom: 12px !important;
}
#dnulist {
    margin-top: 10px;
}
#stats .box.pad.center, #stats .box.center {
    background: #eee !important;
}
ul .invitetree {
    margin: 0 0 0 25px;
}
.invitetree li {
    margin: 10px 2px;
}
.head a:hover, .colhead a:hover, .colhead_dark a:hover, .head a:focus, .colhead a:focus, .colhead_dark a:focus {
    background: transparent !important;
    outline: 0;
}
.user_options .options_list li {
    margin: 0;
}
#store .linkbox {
    text-align: center !important;
}
.layout.recent>tbody>tr:nth-child(2)>td:nth-child(1)>a>img:first-child {
    width: 130px;
    height: 132px;
}
.layout.recent tr:not(:first-child) td {
    padding: 0;
}
.layout.recent img {
    width: 132px;
}
.poll {
    list-style: none;
    padding: 10px;
    margin: 5px;
}
.poll li {
    clear: both;
}
.poll .graph {
    padding: 0 0 15px 0;
}
.poll .graph span {
    display: block;
    height: 19px;
    float: left;
}
.poll .graph .left_poll {
    width: 9px;
    background: rgba(255, 255, 255, 0.4);
}
.poll .graph .center_poll {
    background: rgba(255, 255, 255, 0.4);
}
.poll .graph .right_poll {
    width: 11px;
    background: rgba(255, 255, 255, 0.4);
}
.breadcrumbs {
    font-weight: 300 !important;
}
.curtain {
    position: fixed;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    background: #111 50% 0 no-repeat fixed;
    z-index: 1001;
    -moz-opacity: .9;
    opacity: .9;
    filter: alpha(opacity=90);
}
.lightbox {
    position: fixed;
    text-align: center;
    top: 5%;
    left: 5%;
    width: 90%;
    height: 90%;
    padding: 0;
    z-index: 1002;
    overflow: auto;
}
.lightbox img {
    max-width: 100%;
    max-height: 100%;
    background-color: transparent;
    z-index: -1;
}
button {
    padding: 5px;
    color: #000;
    background: linear-gradient(rgba(255, 255, 255, 0.95),  rgba(255, 255, 255, 0.78));
    border: solid rgba(255, 255, 255, 0.2);
    border-radius: 1px;
    border-width: 0 0 1px 0;
}
button:hover {
    border: solid rgba(255, 255, 255, 0.2);
    border-width: 0 0 1px 0;
    background: linear-gradient(rgba(255, 255, 255, 0.83),  rgba(255, 255, 255, 0.68));
    outline: none;
}
button:active {
    background: linear-gradient(rgba(255, 255, 255, 0.69),  rgba(255, 255, 255, 0.79));
    border: solid rgba(255, 255, 255, 0.2);
    border-width: 0 0 1px 0;
    outline: none;
}
input[type=button], input[type=submit]
{
    -moz-box-sizing: border-box;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    font-size: 10px;
    height: 30px;
    background: linear-gradient(rgba(255, 255, 255, 0.95),  rgba(255, 255, 255, 0.78));
    display: inline-block;
    padding: 9px 12px;
    text-transform: uppercase;
    color: #000;
    text-decoration: none;
    border: solid rgba(255, 255, 255, 0.2);
    border-radius: 1px;
    border-width: 0 0 1px 0;
    cursor: pointer;
    outline: none;
}
input[type=button]:hover, input[type=submit]:hover {
    border: solid rgba(255, 255, 255, 0.2);
    border-width: 0 0 1px 0;
    background: linear-gradient(rgba(255, 255, 255, 0.83),  rgba(255, 255, 255, 0.68));
    outline: none;
    transition: all 0.4s;
}
input[type=button]:active, input[type=submit]:active {
    background: linear-gradient(rgba(255, 255, 255, 0.69),  rgba(255, 255, 255, 0.79));
    border: solid rgba(255, 255, 255, 0.2);
    border-width: 0 0 1px 0;
    outline: none;
    transition: all 0.4s;
}
input[type=text], input[type='password'], input[type='search'], input[type='email']
{
    -moz-box-sizing: border-box;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    height: 34px;
    padding: 11px 9px;
    background: rgba(0, 0, 0, 0.3);
    border: 1px solid rgba(255, 255, 255, 0.1);
    display: inline-block;
    margin: 2px;
    color: #fff;
    text-decoration: none;
    border-radius: 1px;
    outline: none;
}
@-moz-document url-prefix() {
input[type=text], input[type='password'], input[type='search'], input[type='email']
{height: initial;}
}
input[type=text]:hover, input[type=text]:focus, input[type='search']:hover, input[type='search']:focus, input[type='password']:hover, input[type='password']:focus, input[type='email']:hover, input[type='email']:focus {
    background: rgba(0, 0, 0, 0.5);
    border: 1px solid rgba(255, 255, 255, 0.3);
    outline: none;
    transition: all 0.4s;
}
::-webkit-search-cancel-button {
    -webkit-appearance: none;
    -moz-appearance: window;
    appearance: none;
}
::-webkit-search-cancel-button:after {
    content: '';
    display: block;
    width: 11px;
    height: 11px;
    background-image: url('./images/light-on-dark/clear-field.png');
    background-repeat: no-repeat;
    background-size: 11px;
    background-position: top left;
}
select[disabled=disabled] {
    background: #4f4f4f;
    color: #dfdfdf;
}
select[disabled=disabled]:hover, select[disabled=disabled]:focus, select[disabled=disabled]:active {
    background-color: #4f4f4f;
    color: #dfdfdf;
}
select {
    background: url('./images/light-on-dark/dropdown.png'), rgba(0, 0, 0, 0.3);
    background-repeat: no-repeat;
    background-size: 20px;
    background-position: right 2px top 2px, 0 0;
    border: 1px solid rgba(255, 255, 255, 0.1);
    border-radius: 1px;
    display: inline-block;
    color: #fff;
    -webkit-appearance: none;
    appearance: none;
    font-family: 'Source Sans Pro', Helvetica, Arial, sans-serif;
    -moz-box-sizing: border-box;
    -webkit-box-sizing: border-box;
    box-sizing: border-box;
    margin: 2px;
    height: 26px;
    padding: 5px 41px 5px 5px;
    text-decoration: none;
}
@-moz-document url-prefix() {
    select {
    padding: 5px 41px 5px 5px;
    -moz-appearance: none;
    text-indent: .01px;
    text-overflow: '';
    background-position: 2px right center;
}
}@-moz-document url-prefix() {
    #searchbars input {
    padding: 8px;
}
}option {
    background: rgba(0, 0, 0, 0.5);
    border: 1px solid rgba(255, 255, 255, 0.3);
    border-radius: 1px;
    color: #fff;
    text-decoration: none;
    font-family: 'Source Sans Pro', Helvetica, Arial, sans-serif;
}
select:hover {
    border: 1px solid rgba(255, 255, 255, 0.3);
    background: url('./images/light-on-dark/dropdown-hover.png'), rgba(0, 0, 0, 0.3);
    background-repeat: no-repeat;
    background-size: 20px;
    background-position: right 2px top 2px, 0 0;
    border-radius: 1px;
    transition: all 0.4s;
}
option:hover {
    border: 1px solid rgba(255, 255, 255, 0.3);
    background: rgba(0, 0, 0, 0.5);
    background-repeat: no-repeat, repeat;
    background-position: right 2px top 2px, 0 0;
    border-radius: 1px;
}
select:active, select:focus {
    border: 1px solid rgba(255, 255, 255, 0.3);
    background: url('./images/light-on-dark/dropdown-pressed.png'), rgba(0, 0, 0, 0.3);
    background-repeat: no-repeat;
    background-size: 20px;
    background-position: right 2px top 2px, 0 0;
    outline: none;
    color: #fff;
    font-family: 'Source Sans Pro', Helvetica, Arial, sans-serif;
    transition: all 0.4s;
}
#logchecker .thin, #logchecker h3, .log_outer, .log_outer h3 {
    color: #fff;
}
.spellcheck {
    margin: 10px 0;
    font-size: 1.25em;
    font-weight: bold;
}
ul, ol {
    list-style-position: inside;
}
tr.torrent .bookmark>a:before {
    color: #658054;
}
tr.torrent .bookmark>a:after {
    color: #658054;
}
#requests .forum_post textarea {
    max-width: 409px;
}
.linkbox .brackets:before, .linkbox .brackets:after, .top10_quantity_link .brackets:before, .top10_quantity_link .brackets:after {
    color: #fff;
}
.field_div {
    margin-bottom: 10px;
}
.edit_changelog textarea {
    width: 600px;
}
div[class~=tooltipster-base] {
    background-color: #ececec;
    color: #fff;
}
div[class~=tooltipster-content]>a {
    color: rgba(255, 255, 255, 0.6);
}
#settings_sections #settings_search {
    margin: 3px 0;
}
#settings_sections #submit {
    margin: 3px 0 15px 0;
}
#settings_sections {
    position: relative !important;
}
#settings_sections h2 {
    font-size: 1em !important;
}
.vote_tag_up, .vote_tag_down, .vote_artist_up, .vote_album_up, .vote_artist_down, .vote_album_down, .small_upvote, .small_upvoted, .small_downvote, .small_downvoted, .vote_artist_up.brackets, .vote_album_up.brackets, .vote_artist_down.brackets, .vote_album_down.brackets {
    color: transparent !important;
    background-position: 0 6px;
    background-repeat: no-repeat;
    display: inline-block;
    width: 8px;
}
.vote_tag_up, .vote_tag_down {
    margin-right: 2px;
    margin-left: 2px;
}
.vote_artist_up, .vote_album_up, .vote_artist_down, .vote_album_down {
    width: 12px !important;
    background-position: 0 4px !important;
}
.vote_artist_up, .vote_album_up {
    background-image: url('./images/upvote.png');
    background-size: 10px;
}
.vote_artist_down, .vote_album_down {
    background-image: url('./images/downvote.png');
    background-size: 10px;
}
.small_upvote, .small_upvoted, .vote_tag_up, .vote_artist_up.brackets, .vote_album_up.brackets {
    background-image: url('./images/upvote-small.png');
    background-size:auto 5px;
}
.small_downvote, .small_downvoted, .vote_tag_down, .vote_artist_down.brackets, .vote_album_down.brackets {
    background-image: url('./images/downvote-small.png');
    background-size:auto 5px;
}
.small_upvote:active, .small_upvoted:active, .vote_artist_up.brackets:active, .vote_album_up.brackets:active {
    background-image: url('./images/upvote-small-pressed.png');
}
.small_downvote:active, .small_downvoted:active, .vote_artist_down.brackets:active, .vote_album_down.brackets:active {
    background-image: url('./images/downvote-small-pressed.png');
}
#top10 td.votes_info_td>span:nth-child(1)>span:nth-child(1)>span.vote_album_up {
    background-image: url('./images/upvote-small.png');
    background-position: 0 6px !important;
}
#top10 td.votes_info_td>span:nth-child(1)>span:nth-child(2)>span.vote_album_down {
    background-image: url('./images/downvote-small.png');
    background-position: 0 6px !important;
}
.small_clearvote {
    color: transparent !important;
    background-image: url('./images/light-on-dark/x.png');
    background-repeat: no-repeat;
    background-position: 0 6px;
}
a[onclick^='remove_selection'], .remove.remove_artist a {
    color: transparent !important;
    background-image: url('./images/light-on-dark/x.png');
    background-repeat: no-repeat;
    background-position: 3px 4px;
    background-size: 8px;
    filter: invert(50%);
}
.remove.remove_tag a {
    color: transparent !important;
    background-image: url('./images/light-on-dark/x.png');
    background-repeat: no-repeat;
    background-position: 0 6px;
}
a[onclick^='remove_selection'] .brackets:before, a[onclick^='remove_selection'] .brackets:after, .edit_tags_votes .brackets:after, .edit_tags_votes .brackets:before {
    content: none !important;
}
#better .thin.box.pad .torrent_table {
    margin-left: -12px;
    margin-bottom: -12px;
}
#better .thin .box.pad {
    padding: 10px !important;
}
#better .thin #lists+.box.pad {
    padding: 0 !important;
}
strong.important_text {
    background: #a16ac8 !important;
	color:#fff !important;
}
strong.important_text_alt {
    background: #3BA53B !important;
    color:#fff !important;
}
.invalid, .warning {
    background:#ffb729 !important;
	color:#fff !important
}
.new {
    background: #03c2f2 !important;
	color:#fff !important;
}
.error, .torrent_table>tbody>tr>td>strong.important_text {
    background: #ee372a !important;
	color:#fff !important
}
strong.important_text, strong.important_text_alt, .invalid, .warning, .new, .error {
	font-weight: 600;
	padding: 1px 2px;
	display: inline-block;
	margin: 0 2px 1px;
	-webkit-border-radius: 2px !important;
	-moz-border-radius: 2px !important;
	border-radius: 2px !important;
	opacity: 0.9;
}
.message_table>tbody>tr>td>strong.important_text_alt {
    color: #82ff6e !important;
    text-shadow: 0 0 2px rgba(130, 255, 110, 0.8) !important;
}
#rules .box.pad.rule_table {
    padding: 0 !important;
}
body#forums table.forum_post td.body>div, body#userhistory table.forum_post td.body>div {
    width: 719px;
}
div.sidebar #event_div {
    margin-left: -50px;
}
#covers img {
    width: 240px;
}
#covers img[height='220']
{
    height: initial !important;
}
#covers .pad {
    padding: 0;
}
.sidebar img {
    max-width: 240px;
}
.sidebar .box_description .pad img {
    max-width: 100%}
.box_description .pad a {
    word-break: break-all;
}
#artist .sidebar .box_image img {
    width: 240px;
}
#artist .sidebar .box_image div[style='text-align: center; padding: 10px 0px;']
{
    padding: 0 !important;
}
#merchbox img, #merchbox+.box img {
    width: 240px;
    margin: -12px;
}
.box_image_avatar img {
    width: 240px;
    max-height: 1000px !important;
}
#merchbox+.box .head.colhead_dark+.center.pad {
    display: none;
}
#merchbox .center.pad+.center.pad {
    display: none;
}
.news_post img, .wiki_article img {
    max-width: 565px;
}
#reportsv2 .manage_form img {
    max-width: 622px;
}
input[type='search']
{
    font-size: 12px;
    font-weight: 400 !important;
}
#content>div>div.sidebar>div.box.box_search>ul>li {
    margin-bottom: 0;
}
#content>div>div.sidebar>div.box.box_search, .box_addartists_similar {
    padding-bottom: 8px;
}
.tooltipster-default {
    border-radius: 0;
    border: 1px solid rgba(255, 255, 255, 0.15) !important;
    background: rgba(59, 62, 66, 0.9) !important;
    color: #fff !important;
}
#noty_bottomRight_layout_container li {
    border-top-left-radius: 1px !important;
    border-top-right-radius: 1px !important;
    border-bottom-right-radius: 1px !important;
    border-bottom-left-radius: 1px !important;
    color: #fff !important;
    background-image: none !important;
    background: #393a3b !important;
    border: 1px solid #535455 !important;
    margin: initial !important;
    margin-top: 20px !important;
    box-shadow: none !important;
}
.noty_buttons {
    background-image: none !important;
    background: #535455 !important;
    border: none !important;
}
.noty_buttons a {
    color: rgba(255, 255, 255, 0.6);
}
.noty_buttons a:hover {
    color: #02c2f2 !important;
}
.rippywrap {
    color: #fff;
    right: 10px;
}
span.rbt {
    background: url('images/rippy/rippy_top.png') no-repeat top;
}
span.rbm {
    background: url('images/rippy/rippy_middle.png') repeat bottom;
}
span.rbb {
    background: url('images/rippy/rippy_bottom.png') no-repeat bottom;
}
#musicbrainz_popup {
    background: rgba(44, 44, 44, 0.9) !important;
    z-index: 10000 !important;
}
#musicbrainz_popup h1, #musicbrainz_popup h2 {
    color: #fff !important;
    font-weight: initial !important;
}
#musicbrainz_popup #popup_close {
    color: #fff !important;
    font-weight: initial !important;
}
img[alt='Snatches']
{
	background: url('./images/light-on-dark/snatched.png') no-repeat scroll 0 0 transparent;
    background-size:15px;
    height: 15px;
    width: 0;
    padding-right: 15px;
}
img[alt='Seeders']
{
    background: url('./images/light-on-dark/seeders.png') no-repeat scroll 0 0 transparent;
    background-size:11px;
    height: 15px;
    padding-right: 11px;
    width: 0;
}
img[alt='Leechers']
{
    background: url('./images/light-on-dark/leechers.png') no-repeat scroll 0 0 transparent;
    background-size:11px;
    height: 15px;
    padding-right: 11px;
    width: 0;
}
img[src='static/common/symbols/disabled.png'] {
    content: url('./images/user-icons/disabled.png');
    height: 16px;
    width: 16px;
    margin-top: -2px;
    margin-left: 2px;
    margin-bottom: -2px;
}
img[src='static/common/symbols/warned.png'] {
    content: url('./images/user-icons/warned.png');
    height: 16px;
    width: 16px;
    margin-top: -2px;
    margin-left: 2px;
    margin-bottom: -2px;
}
img[src='static/common/symbols/contest.png']
{
    background: url('./images/user-icons/contest.png') no-repeat scroll 0 0 transparent;
    background-size: 100%;
    height: 16px !important;
    margin-top: -2px;
    margin-bottom: -2px;
    padding-right: 15px !important;
    width: 0 !important;
}
img[src='static/common/avatars/default.png']
{
    content: url('./images/dark-on-light/default-avatar.png')
}
img[src*='/donor.png']
{
    background: url('./images/user-icons/donor_1.png') no-repeat scroll 0 0 transparent;
    background-size: 100%;
    height: 13px !important;
    padding-right: 15px !important;
    width: 0 !important;
}
img[src*='/donor_2.png']
{
    background: url('./images/user-icons/donor_2.png') no-repeat scroll 0 0 transparent;
    background-size: 100%;
    height: 13px !important;
    padding-right: 15px !important;
    width: 0 !important;
}
img[src*='/donor_3.png']
{
    background: url('./images/user-icons/donor_3.png') no-repeat scroll 0 0 transparent;
    background-size: 100%;
    height: 13px !important;
    padding-right: 15px !important;
    width: 0 !important;
}
img[src*='/donor_4.png']
{
    background: url('./images/user-icons/donor_4.png') no-repeat scroll 0 0 transparent;
    background-size: 100%;
    height: 13px !important;
    padding-right: 15px !important;
    width: 0 !important;
}
img[src*='/donor_5.png']
{
    background: url('./images/user-icons/donor_5.png') no-repeat scroll 0 0 transparent;
    background-size: 100%;
    height: 13px !important;
    padding-right: 15px !important;
    width: 0 !important;
}
img[src*='/donor_6.png']
{
    background: url('./images/user-icons/donor_6.png') no-repeat scroll 0 0 transparent;
    background-size: 100%;
    height: 13px !important;
    padding-right: 15px !important;
    width: 0 !important;
}
#log span[style='color: blue;']
{
    color: #a5e9ff !important;
}
#log span[style='color: green;']
{
    color: #66b366 !important;
}

/**** Smileys ****/

img[src*='smileys/angry.gif'] {
    content: url('./images/smileys/angry.png');
    height: 20px;
    width: 20px;
}
img[src*='smileys/biggrin.gif'] {
    content: url('./images/smileys/biggrin.png');
    height: 20px;
    width: 20px;
}
img[src*='smileys/blank.gif'] {
    content: url('./images/smileys/blank.png');
    height: 20px;
    width: 20px;
}
img[src*='smileys/blush.gif'] {
    content: url('./images/smileys/blush.png');
    height: 20px;
    width: 20px;
}
img[src*='smileys/cool.gif'] {
    content: url('./images/smileys/cool.png');
    height: 20px;
    width: 20px;
}
img[src*='smileys/creepy.gif'] {
    content: url('./images/smileys/creepy.png');
    height: 20px;
    width: 20px;
}
img[src*='smileys/crying.gif'] {
    content: url('./images/smileys/crying.png');
    height: 20px;
    width: 20px;
}
img[src*='smileys/eyesright.gif'] {
    content: url('./images/smileys/eyesright.png');
    height: 20px;
    width: 20px;
}
img[src*='smileys/frown.gif'] {
    content: url('./images/smileys/frown.png');
    height: 20px;
    width: 20px;
}
img[src*='smileys/heart.gif'] {
    content: url('./images/smileys/heart.png');
    height: 20px;
    width: 20px;
}
img[src*='smileys/hmm.gif'] {
    content: url('./images/smileys/hmm.png');
    height: 20px;
    width: 20px;
}
img[src*='smileys/laughing.gif'] {
    content: url('./images/smileys/laughing.png');
    height: 20px;
    width: 20px;
}
img[src*='smileys/loveflac.gif'] {
    content: url('./images/smileys/loveflac.png');
    height: 31px;
    width: auto;
}
img[src*='smileys/ninja.gif'] {
    content: url('./images/smileys/ninja.png');
    height: 20px;
    width: 20px;
}
img[src*='smileys/ohnoes.gif'] {
    content: url('./images/smileys/ohnoes.png');
    height: 20px;
    width: 20px;
}
img[src*='smileys/ohshit.gif'] {
    content: url('./images/smileys/ohshit.png');
    height: 20px;
    width: 20px;
}
img[src*='smileys/omg.gif'] {
    content: url('./images/smileys/omg.png');
    height: 20px;
    width: 20px;
}
img[src*='smileys/paddle.gif'] {
    content: url('./images/smileys/paddle.png');
    height: 29px;
    width: auto;
}
img[src*='smileys/pthlove.gif'] {
    content: url('./images/smileys/redlove.png');
    height: 31px;
    width: auto;
}
img[src*='smileys/sad.gif'] {
    content: url('./images/smileys/sad.png');
    height: 20px;
    width: 20px;
}
img[src*='smileys/shifty.gif'] {
    content: url('./images/smileys/shifty.gif');
    height: 20px;
    width: 20px;
}
img[src*='smileys/sick.gif'] {
    content: url('./images/smileys/sick.png');
    height: 20px;
    width: 20px;
}
img[src*='smileys/smile.gif'] {
    content: url('./images/smileys/smile.png');
    height: 20px;
    width: 20px;
}
img[src*='smileys/sorry.gif'] {
    content: url('./images/smileys/sorry.png');
    height: 31px;
    width: auto;
}
img[src*='smileys/thanks.gif'] {
    content: url('./images/smileys/thanks.png');
    height: 31px;
    width: auto;
}
img[src*='smileys/tongue.gif'] {
    content: url('./images/smileys/tongue.png');
    height: 20px;
    width: 20px;
}
img[src*='smileys/wink.gif'] {
    content: url('./images/smileys/wink.png');
    height: 20px;
    width: 20px;
}
img[src*='smileys/worried.gif'] {
    content: url('./images/smileys/worried.png');
    height: 20px;
    width: 20px;
}
img[src*='smileys/wtf.gif'] {
    content: url('./images/smileys/wtf.png');
    height: 20px;
    width: 20px;
}
img[src*='smileys/wub.gif'] {
    content: url('./images/smileys/wub.png');
    height: 30px;
    width: auto;
}

/**** Plugin Support ****/

.gm_color_freeleech {
	background:#3BA53B !important;
	color:#fff !important
}
.gm_color_neutralleech {
	background:#a8e687 !important;
	color:#fff !important
}
.gm_color_reported {
	background:#ee372a !important;
	color:#fff !important
}
.gm_color_badtags {
	background:#F4D524 !important;
	color:#fff !important
}
.gm_color_badfolders {
	background:#eee08e !important;
	color:#fff !important
}
.gm_color_cassetteapproved {
	background:#0992B5 !important;
	color:#fff !important
}
.gm_color_lossymasterapproved {
	background:#6B6FBF !important;
	color:#fff !important
}
.gm_color_badfilenames {
	background:#84795F !important;
	color:#fff !important
}
.gm_color_personalfreeleech {
	background:#ffbfcb !important;
	color:#fff!important
}
.gm_color_trumpable {
	background:#ffb729 !important;
	color:#fff !important
}
.gm_color_snatched {
	background:#01b0d8 !important;
	color:#fff !important
}



.linkbox a[href*='last'] img {
    content: url('./images/plugins-support/lastfm.png');
    width: 15px;
    height: 15px;
    padding-left: 8px;
}
.linkbox a[href*='discogs'] img {
    content: url('./images/plugins-support/discogs-white.png');
    width: 15px;
    height: 15px;
    padding-left: 8px;
}
.linkbox a[href*='musicbrainz'] img {
    content: url('./images/plugins-support/musicbrainz.png');
    width: 15px;
    height: 15px;
    padding-left: 8px;
}
.linkbox a[href*='rateyourmusic'] img {
    content: url('./images/plugins-support/rateyourmusic.png');
    width: 15px;
    height: 15px;
    padding-left: 8px;
}

table.important_user_not_OP {
    border-right: 2px solid #ff8901;
    border-width: 0 2px 0 0;
    box-shadow: none !important;
}

#gt10_saving.important_text_alt {
    background: none !important;
}

#scrollUp {
	background-image: url('./images/plugins-support/scrollup.png');
    background-size: 30px;
    display: box;
	color:#fff !important
    opacity: 1;
    height: 50px;
    width: 50px;
    cursor: pointer;
}
#scrollUp:before {
    display: none
}
#scrollStop {
	background-image: url('./images/plugins-support/pausescroll.png');
    background-size: 30px;
    display: box;
	color:#fff !important
    opacity: 1;
    height: 50px;
    width: 50px;
    cursor: pointer;
}
#scrollStop:before {
    display: none
}

div[style='width: 400px; height: 30px; background: rgba(64,64,64,0.8); border: dashed; border-radius: 10px; margin: auto; text-align: center; font-size: 20px;'] {
    width: 600px !important;
    height: 40px !important;
    background: rgba(255, 255, 255, 0.05) !important;
    border: 2px dashed rgba(255, 255, 255, 0.30) !important;
    margin: 15px auto !important;
    text-transform: uppercase !important;
    font-size: 15px !important;
    font-weight: 600;
    color: rgba(255, 255, 255, 0.50);
    line-height: 40px;
}


/**** Misc ****/

img[alt='The Apple Way']
{
    content: url('./images/user-icons/The-Apple-Way.png');
    height: 16px;
    width: 16px;
    margin-top: -2px;
}
