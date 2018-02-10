var AvanisHerbalSalon;
(function (AvanisHerbalSalon) {
    var Controllers;
    (function (Controllers) {
        var HomeController = (function () {
            function HomeController() {
            }
            return HomeController;
        }());
        Controllers.HomeController = HomeController;
        var AboutController = (function () {
            function AboutController() {
            }
            return AboutController;
        }());
        Controllers.AboutController = AboutController;
        var HairCareController = (function () {
            function HairCareController($http, $state) {
                var _this = this;
                this.$http = $http;
                this.$state = $state;
                $http.get('/api/items/haircare').then(function (response) {
                    _this.items = response.data;
                });
                $http.get('/api/category').then(function (response) {
                    _this.categories = response.data;
                });
            }
            HairCareController.prototype.addItem = function () {
                var _this = this;
                this.$http.post('/api/items', this.item).then(function (res) {
                    _this.$state.reload();
                });
            };
            return HairCareController;
        }());
        Controllers.HairCareController = HairCareController;
        var EditHairCareController = (function () {
            function EditHairCareController($http, $state) {
                var _this = this;
                this.$http = $http;
                this.$state = $state;
                $http.get('/api/items/edithaircare').then(function (response) {
                    _this.items = response.data;
                });
                $http.get('/api/category').then(function (response) {
                    _this.categories = response.data;
                });
            }
            EditHairCareController.prototype.editItem = function () {
                var _this = this;
                this.$http.post('/api/items', this.item).then(function (res) {
                    _this.$state.reload();
                });
            };
            return EditHairCareController;
        }());
        Controllers.EditHairCareController = EditHairCareController;
        var SkinCareController = (function () {
            function SkinCareController($http, $state) {
                var _this = this;
                this.$http = $http;
                this.$state = $state;
                $http.get('/api/items/skincare').then(function (response) {
                    _this.items = response.data;
                });
                $http.get('/api/category').then(function (response) {
                    _this.categories = response.data;
                });
            }
            SkinCareController.prototype.addItem = function () {
                var _this = this;
                this.$http.post('/api/items', this.item).then(function (res) {
                    _this.$state.reload();
                });
            };
            return SkinCareController;
        }());
        Controllers.SkinCareController = SkinCareController;
        var MassageController = (function () {
            function MassageController($http, $state) {
                var _this = this;
                this.$http = $http;
                this.$state = $state;
                $http.get('/api/items/massage').then(function (response) {
                    _this.items = response.data;
                });
                $http.get('/api/category').then(function (response) {
                    _this.categories = response.data;
                });
            }
            MassageController.prototype.addItem = function () {
                var _this = this;
                this.$http.post('/api/items', this.item).then(function (res) {
                    _this.$state.reload();
                });
            };
            return MassageController;
        }());
        Controllers.MassageController = MassageController;
        var NailCareController = (function () {
            function NailCareController($http, $state) {
                var _this = this;
                this.$http = $http;
                this.$state = $state;
                $http.get('/api/items/nailcare').then(function (response) {
                    _this.items = response.data;
                });
                $http.get('/api/category').then(function (response) {
                    _this.categories = response.data;
                });
            }
            NailCareController.prototype.addItem = function () {
                var _this = this;
                this.$http.post('/api/items', this.item).then(function (res) {
                    _this.$state.reload();
                });
            };
            return NailCareController;
        }());
        Controllers.NailCareController = NailCareController;
        var ServicesController = (function () {
            function ServicesController($http) {
                var _this = this;
                $http.get('/api/items').then(function (response) {
                    _this.items = response.data;
                });
                $http.get('/api/category').then(function (response) {
                    _this.categories = response.data;
                });
            }
            return ServicesController;
        }());
        Controllers.ServicesController = ServicesController;
        var AppointmentController = (function () {
            function AppointmentController($http, $state) {
                var _this = this;
                this.$http = $http;
                this.$state = $state;
                $http.get('/api/items').then(function (response) {
                    _this.items = response.data;
                });
                $http.get('/api/category').then(function (response) {
                    _this.categories = response.data;
                });
            }
            AppointmentController.prototype.additem = function () {
                var _this = this;
                this.$http.post('/api/items', this.item).then(function (res) {
                    _this.$state.reload();
                });
            };
            return AppointmentController;
        }());
        Controllers.AppointmentController = AppointmentController;
        var ContactController = (function () {
            function ContactController($resource) {
                this.$resource = $resource;
                this.ContactResource = $resource('/api/contacts/:id');
                this.getContacts();
            }
            ContactController.prototype.getContacts = function () {
                this.contact = this.ContactResource.query();
            };
            ContactController.prototype.save = function () {
                var _this = this;
                this.ContactResource.save(this.contacts).$promise.then(function () {
                    _this.contact = null;
                    _this.getContacts();
                });
            };
            return ContactController;
        }());
        Controllers.ContactController = ContactController;
        var SecretController = (function () {
            function SecretController($http, $state) {
                var _this = this;
                this.$http = $http;
                this.$state = $state;
                $http.get('/api/secrets').then(function (results) {
                    _this.secrets = results.data;
                });
                $http.get('/api/categories').then(function (results) {
                    _this.categories = results.data;
                });
            }
            SecretController.prototype.additem = function () {
                var _this = this;
                this.$http.post('/api/items', this.items).then(function (res) {
                    _this.$state.reload();
                });
            };
            return SecretController;
        }());
        Controllers.SecretController = SecretController;
    })(Controllers = AvanisHerbalSalon.Controllers || (AvanisHerbalSalon.Controllers = {}));
})(AvanisHerbalSalon || (AvanisHerbalSalon = {}));
//# sourceMappingURL=controllers.js.map