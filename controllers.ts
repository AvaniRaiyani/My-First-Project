namespace AvanisHerbalSalon.Controllers {

    export class HomeController {
    }

    export class AboutController {
    }

    export class HairCareController {
        public items;
        public categories;
        public item;
        public haircare;

        public addItem(){
            this.$http.post('/api/items', this.item).then((res) => {
                this.$state.reload();
            })
            
        }

        constructor(private $http: ng.IHttpService, private $state: ng.ui.IStateService) {
            $http.get('/api/items/haircare').then((response) => {
                this.items = response.data;
            });

            $http.get('/api/category').then((response) => {
                this.categories = response.data;
            });
        }
    }

    export class EditHairCareController {
        public items;
        public categories;
        public item;
        public haircare;

        public editItem() {
            this.$http.post('/api/items', this.item).then((res) => {
                this.$state.reload();
            })
        }

        constructor(private $http: ng.IHttpService, private $state: ng.ui.IStateService) {
            $http.get('/api/items/edithaircare').then((response) => {
                this.items = response.data;
            });

            $http.get('/api/category').then((response) => {
                this.categories = response.data;
            });
        }
    }

    export class SkinCareController {
        public items;
        public categories;
        public item;
        public skincare;

        public addItem() {
            this.$http.post('/api/items', this.item).then((res) => {
                this.$state.reload();
            })
        }

        constructor(private $http: ng.IHttpService, private $state: ng.ui.IStateService) {
            $http.get('/api/items/skincare').then((response) => {
                this.items = response.data;
            });

            $http.get('/api/category').then((response) => {
                this.categories = response.data;
            });
        }
    }

    export class MassageController {
        public items;
        public categories;
        public item;
        public massage;

        public addItem() {
            this.$http.post('/api/items', this.item).then((res) => {
                this.$state.reload();
            })
        }

        constructor(private $http: ng.IHttpService, private $state: ng.ui.IStateService) {
            $http.get('/api/items/massage').then((response) => {
                this.items = response.data;
            });

            $http.get('/api/category').then((response) => {
                this.categories = response.data;
            });
        }
    }

    export class NailCareController {
        public items;
        public categories;
        public item;
        public nailcare;

        public addItem() {
            this.$http.post('/api/items', this.item).then((res) => {
                this.$state.reload();
            })
        }

        constructor(private $http: ng.IHttpService, private $state: ng.ui.IStateService) {
            $http.get('/api/items/nailcare').then((response) => {
                this.items = response.data;
            });

            $http.get('/api/category').then((response) => {
                this.categories = response.data;
            });
        }
    }

    export class ServicesController {
        public items;
        public categories;
        public item;
        public skincare;

        constructor($http: ng.IHttpService) {
            $http.get('/api/items').then((response) => {
                this.items = response.data;
            });

            $http.get('/api/category').then((response) => {
                this.categories = response.data;
            });
        }
    }

    export class AppointmentController {
        public items;
        public categories;
        public item;

        public additem() {
           this.$http.post('/api/items', this.item).then((res) => {
                this.$state.reload();
            })
        }

        constructor(private $http: ng.IHttpService, private $state:ng.ui.IStateService) {
            $http.get('/api/items').then((response) => {
                this.items = response.data;
            });
            $http.get('/api/category').then((response) => {
                this.categories = response.data;
            });
        }
    }
            export class ContactController {
                private ContactResource;
                public contact;
                public contacts;
                public getContacts() {
                    this.contact = this.ContactResource.query()
                }
                public save() {
                    this.ContactResource.save(this.contacts).$promise.then(() => {
                        this.contact = null;
                        this.getContacts();
                    });
                }
                constructor(private $resource: angular.resource.IResourceService) {
                    this.ContactResource = $resource('/api/contacts/:id');
                    this.getContacts();
                }
            }
            export class SecretController {
                public secrets;
                public items;
                public categories;

                public additem() {
                    this.$http.post('/api/items', this.items).then((res) => {
                        this.$state.reload();
                    })
                }
                constructor(private $http: ng.IHttpService, private $state: ng.ui.IStateService) {
                    $http.get('/api/secrets').then((results) => {
                        this.secrets = results.data;
                    });
                    $http.get('/api/categories').then((results) => {
                        this.categories = results.data;
                    })
                }
            }
        }
    