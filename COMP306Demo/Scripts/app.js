var ViewModel = function () {
    var self = this;
    self.games = ko.observableArray();
    self.error = ko.observable();
    self.detail = ko.observable();

    var gamesUri = '/api/Games/';

    self.getGameDetail = function (item) {
        ajaxHelper(gamesUri + item.Id, 'GET').done(function (data) {
            self.detail(data);
        });
    }

    self.newGame = {
        Id: ko.observable(),
        Title: ko.observable(),
        Year: ko.observable(),
        Price: ko.observable(),
        Genre: ko.observable()
    }

    function ajaxHelper(uri, method, data) {
        self.error('');
        return $.ajax({
            type: method,
            url: uri,
            dataType: 'json',
            contentTtype: 'application/json',
            data: data ? JSON.stringify(data) : null
        }).fail(function (jqXHR, textStatus, errorThrown) {
            self.error(errorThrown);
        });
    }

    function getAllGames() {
        ajaxHelper(gamesUri, 'GET').done(function (data) {
            self.games(data);
        });
    }

    self.addGame = function (formElement) {
        var game = {
            Id: self.newGame.Id,
            Title: self.newGame.Title(),
            Year: self.newGame.Year(),
            Price: self.newGame.Price(),
            Genre: self.newGame.Genre()
        };

        ajaxHelper(gamesUri, 'POST', game).done(function (item) {
            self.games.push(item);
        });
    }

    getAllGames();
};

ko.applyBindings(new ViewModel());