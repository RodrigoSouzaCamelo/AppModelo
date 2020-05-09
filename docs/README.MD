libman install jquery@3.5.1 --provider cdnjs --destination wwwroot/lib/jquery/ --files core.js --files jquery.js

libman install jquery-validate@1.19.0 --provider cdnjs --destination wwwroot/lib/jquery-validate/ --files localization/methods_pt.js --files jquery.validate.js --files additional-methods.js

libman install jquery-validation-unobtrusive@3.2.11 --provider cdnjs --destination wwwroot/lib/jquery-validation-unobtrusive/ --files jquery.validate.unobtrusive.js 

libman install twitter-bootstrap@4.4.0 --provider cdnjs --destination wwwroot/lib/bootstrap --files js/bootstrap.js --files css/bootstrap.css --files css/bootstrap-reboot.css --files css/bootstrap-grid.css

libman install font-awesome@4.7.0 --provider cdnjs --destination wwwroot/lib/font-awesome --files css/font-awesome.css --files fonts/*