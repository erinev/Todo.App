var Router = Backbone.Router.extend({
    initialize: function() {
        /*if (window['initialData'] != undefined) {
            this.syncBannerModel = new SyncBannerModel(initialData);
            ;
            this.syncBannerView = new SyncBannerView({
                model: this.syncBannerModel
            });
            this.syncBannerView.render();
        } else {
            $.modal(
                {
                    title: multiPanelResources.errorTitle,
                    body: multiPanelResources.initialData,
                    buttons: [{ title: multiPanelResources.ok}]
                
                });
        }*/
    }
});

var router = new Router;

Backbone.history.start();