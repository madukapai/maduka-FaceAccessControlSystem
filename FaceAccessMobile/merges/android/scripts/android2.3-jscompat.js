// Android 2.3 上的 Polyfill for Function.prototype.bind() 支援
(function () {
    if (!Function.prototype.bind) {
        Function.prototype.bind = function (thisValue) {
            if (typeof this !== "function") {
                throw new TypeError(this + " cannot be bound as it is not a function");
            }

            // bind() 也可允許在呼叫前面加上引數
            var preArgs = Array.prototype.slice.call(arguments, 1);

            // 實際的函式，可將 "this" 值與引數繫結至
            var functionToBind = this;
            var noOpFunction = function () { };

            // 要使用的 "this" 引數
            var thisArg = this instanceof noOpFunction && thisValue ? this : thisValue;

            // 所產生的繫結函式
            var boundFunction = function () {
                return functionToBind.apply(thisArg, preArgs.concat(Array.prototype.slice.call(arguments)));
            };

            noOpFunction.prototype = this.prototype;
            boundFunction.prototype = new noOpFunction();

            return boundFunction;
        };
    }
}());
