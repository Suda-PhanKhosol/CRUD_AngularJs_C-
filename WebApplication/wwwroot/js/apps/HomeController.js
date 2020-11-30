"use strict";
myapp.controller('HomeController', function ($scope, $http) {
    $scope.text = "Hello World!";
    $scope.check = true;
    $scope.departments = {};
    $scope.emp = {};
    $scope.mode ="show"
    $scope.alives = [{ Text: "Yes", Value: "Y" }, { Text: "No", Value: "N" }];

    $scope.model = {
        Items: []
    };
    $scope.Init = function () {
        $scope.GetEmployee();
        $scope.GetDepartment();
    };
    $scope.GetEmployee = function () {
        $scope.mode = "show"
        $http.get(window.baseUrl + 'Home/GetEmployee', {}).then(function (res) {
            console.log("Home/GetEmployee", res.data);
            $scope.model.Items = res.data;
        });
    }
    $scope.GetDepartment = function () {
        $http.get(window.baseUrl + 'Home/GetDepartment', {}).then(function (res) {
            console.log("Home/GetDepartment", res.data);
            $scope.model.Departments = res.data;
        });
    }

    $scope.Add = function (emp) {
        $scope.model.Items.push($scope.emp);
        $('#modal-xl').modal('hide');
        $scope.emp = {}
        console.log(emp)
    };

    $scope.InsertEmployee = function (emp) {
        $('#modal-xl').modal('hide');
        console.log("Employee Test ", emp)
        //$http.post(window.baseUrl + 'Home/InsertEmployee', JSON.stringify("test")).then(function (res) {
        //	console.log(data)
        //	$scope.GetEmployee();

        //});
        $http.post(window.baseUrl + 'Home/InsertEmployee', emp).then(function (res) {
            console.log(data)
        });

        $scope.GetEmployee();
    };
    $scope.UpdateEmployee = function () {
        $http.post(window.baseUrl + 'Home/UpdateEmployee', $scope.model.Items).then(function (res) {
            $scope.GetEmployee();
            $scope.mode = "show";
        });
    };
    $scope.DeleteEmployee = function (item) {
        console.log(item);
        Swal.fire({
            title: 'Are you sure?',
            text: "You won't be able to revert this!",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Yes, delete it!'
        }).then((result) => {
            if (result.isConfirmed) {
                $http.post(window.baseUrl + 'Home/DeleteEmployee', item).then(function (res) {
                    $scope.GetEmployee();
                });
            }
        })

    };

    $scope.is = {
        CanSubmit: function () {
            return $scope.user.username !== "" && $scope.user.password !== "";
        }
    }

    $scope.items = [{
        id: 1,
        label: 'Admin',
        subItem: { name: 'SubAdmin' }
    }, {
        id: 2,
        label: 'Member',
        subItem: { name: 'SubMember' }
    }];


    $scope.showEmpInsert = function () {
        $('#modal-xl').modal();
    }

    $scope.Submit = function () {
        alert($scope.text);
    };

    $scope.Login = function () {
        console.log($scope.user);
        $scope.user = {};
    };
});