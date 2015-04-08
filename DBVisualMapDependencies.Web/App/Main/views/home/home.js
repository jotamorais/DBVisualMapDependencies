(function() {
    var controllerId = 'app.views.home';
    angular.module('app').controller(controllerId, [
        '$scope', 'abp.services.app.dBObject',
		function ($scope, dbObjectService) {
            var vm = this;
            
            vm.localize = abp.localization.getSource('DBVisualMapDependencies');

            vm.dbObjectDependencies = [];

            vm.init = function () {
            	debugger;
            	abp.ui.setBusy( //Set whole page busy until getTasks complete
                    null,
                    dbObjectService.getDependencies({ //Call application service method directly from javascript
                    	input: 0
                    }).success(function (data) {
                    	debugger;
                    	console.log("DB records", data);
                    	vm.dbObjectDependencies = data.dBObjectDependencies;
                    })
                );
            };

            vm.init();
        }
    ]);
})();