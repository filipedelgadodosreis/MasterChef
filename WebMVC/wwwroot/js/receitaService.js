define([], function () {
    var receitaUrl = '/Home/LatestCookie/';
    function loadLatestCookie() {
        fetch(receitaUrl)
            .then(function (response) {
                return response.json();
            }).then(function (data) {
                console.log(data);
            });
    }
    return {
        loadLatestCookie:
            loadLatestCookie
    }
});