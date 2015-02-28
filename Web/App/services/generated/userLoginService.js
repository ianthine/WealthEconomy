//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

(function () {
    'use strict';

    var serviceId = 'userLoginService';
    angular.module('main')
        .factory(serviceId, ['dataContext', 'logger', userLoginService]);

    function userLoginService(dataContext, logger) {
        logger = logger.forSource(serviceId);

        // To determine whether the data will be fecthed from server or local
        var minimumDate = new Date(0);
        var fetchedOn = minimumDate;

        // Service methods (alphabetically)
        var service = {
            createUserLogin: createUserLogin,
            deleteUserLogin: deleteUserLogin,
            getChanges: getChanges,
            getChangesCount: getChangesCount,
            getUserLoginSet: getUserLoginSet,
            getUserLogin: getUserLogin,
            hasChanges: hasChanges,
            rejectChanges: rejectChanges,
            saveChanges: saveChanges
        };

        return service;

        /*** Implementations ***/

        function createUserLogin(userLogin) {
            return dataContext.createEntity('UserLogins', userLogin);
        }

        function deleteUserLogin(userLogin) {
            userLogin.entityAspect.setDeleted();
        }

        function getChanges() {
            return dataContext.getChanges();
        }

        function getChangesCount() {
            return dataContext.getChangesCount();
        }

        function getUserLoginSet(forceRefresh) {
            var count;
            if (forceRefresh) {
                if (dataContext.hasChanges()) {
                    count = dataContext.getChangesCount();
                    dataContext.rejectChanges(); // undo all unsaved changes!
                    logger.logWarning('Discarded ' + count + ' pending change(s)', null, true);
                }
            }

            var query = breeze.EntityQuery
				.from('UserLogins')
				.expand(['User'])
            ;

            // Fetch the data from server, in case if it's not fetched earlier or forced
            var fetchFromServer = fetchedOn === minimumDate || forceRefresh;

            // Prepare the query
            if (fetchFromServer) { // From remote
                query = query.using(breeze.FetchStrategy.FromServer)
                fetchedOn = new Date();
            }
            else { // From local
                query = query.using(breeze.FetchStrategy.FromLocalCache)
            }

            return dataContext.executeQuery(query)
                .then(success).catch(failed);

            function success(response) {
                count = response.results.length;
                logger.logSuccess('Got ' + count + ' userLogin(s)', response, true);
                return response.results;
            }

            function failed(error) {
                var message = error.message || 'UserLogin query failed';
                logger.logError(message, error, true);
            }
        }

        function getUserLogin(userLoginId, forceRefresh) {
            return dataContext.fetchEntityByKey('UserLogin', userLoginId, !forceRefresh)
                .then(success).catch(failed);

            function success(result) {
                return result.entity;
            }

            function failed(error) {
                var message = error.message || 'getUserLogin query failed';
                logger.logError(message, error, true);
            }
        }

        function hasChanges() {
            return dataContext.hasChanges();
        }

        function rejectChanges() {
            dataContext.rejectChanges();
        }

        function saveChanges() {
            return dataContext.saveChanges();
        }
    }
})();
