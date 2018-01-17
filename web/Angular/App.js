var _app = angular.module('MessageApp', [])

_app.controller('HelloController',
    function ($scope) {
        var message = _storeTree.get(['helloController', 'message']);
        $scope.helloMessage = message;
    });

_app.controller('ChatController',
    function ($scope) {
        $scope.login = function () {
            var username = $scope.username;
            _storeTree.set(['chatController','username'],username);
        }
    });