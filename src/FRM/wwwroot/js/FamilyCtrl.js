// FamilyCtrl.js
(function () {

    'use strict';

    angular.module('app-family')
    .controller('FamilyCtrl', FamilyCtrl);

    function FamilyCtrl() {
        var vm = this;

        vm.familyMembers = [{
            name: "Sara",
            birthday: "08/02/1985"
        },
        {
            name: "Ella",
            birthday: "11/13/2014"
    }];
    }

})();