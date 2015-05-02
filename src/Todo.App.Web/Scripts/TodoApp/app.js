(function () {

    window.TodoApp = {
        Models: {},
        Views: {},
        Collections: {}
    };

    TodoApp.Models.Task = Backbone.Model.extend({
        urlRoot : 'api/v1/tasks/',

        defaults: {
            isCompleted: false
        }
    });

    TodoApp.Collections.Tasks = Backbone.Collection.extend({
        model: TodoApp.Models.Task,

        url: 'api/v1/tasks/'
    });

    TodoApp.Views.Tasks = Backbone.View.extend({
        tagName: 'ul',

        render: function () {
            this.collection.each(this.addOne, this);
            return this;
        },

        addOne: function(task) {
            var taskView = new TodoApp.Views.Task({ model: task });
            this.$el.append(taskView.render().el);
        }
    });

    TodoApp.Views.Task = Backbone.View.extend({
        tagName: 'li',

        render: function () {
            this.$el.html(this.model.get('title'));
            return this;
        }
    });

    var tasksCollection = new TodoApp.Collections.Tasks;
    tasksCollection.fetch().done(function () {
        var tasksView = new TodoApp.Views.Tasks({ collection: tasksCollection });
        $(document.body).append(tasksView.render().el);
    });

})();

/*var Router = Backbone.Router.extend({
    initialize: function() {
        
    }
});
var router = new Router;
Backbone.history.start();*/