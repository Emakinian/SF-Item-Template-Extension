(function (angular) {

    var app = angular.module('designer');
    //app.requires.push('sfDocumentSelector', 'sfSelectors', 'ngSanitize', 'sfFields');

    app.controller('SimpleCtrl', ['$scope', 'propertyService', function ($scope, propertyService) {
        $scope.feedback.showLoadingIndicator = true;


        propertyService.get()
            .then(function (data) {
                if (data) {
                    $scope.properties = propertyService.toAssociativeArray(data.Items);

                    
                }

                $scope.feedback.savingHandlers.push($scope.validate);
                $scope.feedback.savingHandlers.push($scope.save);
            },
            function (data) {
                $scope.feedback.showError = true;
                if (data) {
                    $scope.feedback.errorMessage = data.Detail;
                }
            })
            .finally(function () {
                $scope.feedback.showLoadingIndicator = false;
            });

        $scope.validate = function () {
            var errors = [];

            //if (!$scope.proxy.selectedDocument) {
            //    errors.push("Document is a must.");
            //} else {
            //    if ($scope.proxy.selectedDocument.Extension.toLowerCase() !== ".pdf") {
            //        errors.push("Document extension must be pdf.");
            //    }
            //}

            //if (!$scope.proxy.selectedImage) {
            //    errors.push("Image is a must.");
            //}

            //if (errors.length > 0) {
            //    var strError = "Some error(s) occured: ";
            //    strError += errors.join(["|| "]);

            //    throw strError;
            //}
        };

        $scope.save = function () {
            //$scope.properties.DocumentJson.PropertyValue = JSON.stringify($scope.proxy.selectedDocument);
            //$scope.properties.ImageJson.PropertyValue = JSON.stringify($scope.proxy.selectedImage);
        };
    }]);

}(window.angular));
