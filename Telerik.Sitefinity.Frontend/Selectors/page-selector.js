﻿(function () {
    angular.module('selectors')
        .directive('sfPageSelector', ['sfPageService', "serverContext", function (pageService, serverContext) {
            return {
                require: '^listSelector',
                restrict: 'A',
                link: {
                    pre: function (scope, element, attrs, ctrl) {

                        var rootPage = serverContext.getCurrentFrontendRootNodeId();

                        var getItems = function (parentId, search) {
                            var siteId = ctrl.$scope.siteId;
                            var provider = ctrl.$scope.provider;
                            return pageService.getItems(parentId, siteId, provider, search);
                        };

                        ctrl.getItems = function (skip, take, search) {
                            return getItems(rootPage, search);
                        };

                        ctrl.getChildren = function (parentId, search) {                            
                            return getItems(parentId, search)
                                .then(function (data) {
                                    return data.Items;
                                });
                        };

                        ctrl.getSpecificItems = function (ids) {
                            var provider = ctrl.$scope.provider;
                            return pageService.getSpecificItems(ids, provider);
                        };

                        ctrl.onSelectedItemsLoadedSuccess = function (data) {
                            ctrl.updateSelection(data.Items);
                        };

                        ctrl.selectorType = 'PageSelector';

                        ctrl.dialogTemplateUrl = 'Selectors/page-selector.html';
                        ctrl.$scope.dialogTemplateId = 'page-selector-template';

                        var closedDialogTemplate = attrs.multiselect ?
                            'Selectors/list-group-selection.html' :
                            'Selectors/bubbles-selection.html';

                        ctrl.closedDialogTemplateUrl = closedDialogTemplate;                       

                        ctrl.$scope.hierarchical = true;

                        ctrl.$scope.identifierField = "TitlesPath";

                        ctrl.$scope.searchIdentifierField = "Title";
                    }
                }
            };
        }]);
})();