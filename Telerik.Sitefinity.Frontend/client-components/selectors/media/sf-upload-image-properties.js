﻿; (function () {
    var sfSelectors = angular.module('sfSelectors');
    sfSelectors.requires.push('sfUploadImageProperties');

    angular.module('sfUploadImageProperties', ['sfFlatTaxonField'])
        .directive('sfUploadImageProperties', ['serverContext', 'serviceHelper', function (serverContext, serviceHelper) {
            return {
                restrict: 'E',
                scope: {
                    selectedItem: '=?sfModel'
                },
                templateUrl: function (elem, attrs) {
                    var assembly = attrs.sfTemplateAssembly || 'Telerik.Sitefinity.Frontend';
                    var url = attrs.sfTemplateUrl || 'client-components/selectors/media/sf-upload-image-properties.html';
                    return serverContext.getEmbeddedResourceUrl(assembly, url);
                },
                link: function (scope, element, attrs, ctrl) {
                    scope.tags = [];
                    
                }
            };
        }]);
})();