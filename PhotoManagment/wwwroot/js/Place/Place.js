window.onload = function () {
    var app = new Vue({
        el: '#place',
        data: {
            name: '照片'
        },
        //实现添加页面跳转的方法
        methods:
        {
            add: function ()
            {
                window.location = '/Places/Create';
            }
        }
    })
}