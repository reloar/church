﻿var myApp = angular
    .module("myModule", [])
    .controller("myController", function ($scope) {
       
        var technologies =
        {
            likes: 0,
            dislikes: 0
        }
           
        
        $scope.technologies = technologies;

        $scope.incrementLikes = function (technology) {
            technology.likes++;
        }
        $scope.incrementDislikes = function (technology) {
            technology.dislikes++;
        }
        $scope.technologies = technologies;
    });