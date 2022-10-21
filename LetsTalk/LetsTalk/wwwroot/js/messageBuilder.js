var messageBuilder = function() {
    var message = null;
    var header = null;
    var paragraph = null;
    var footer = null;

    return {
        createMessage: function(classList) {
            message = document.createElement("div");
            if (classList === undefined)
                classList = []

            classList.forEach(function (className)  {
                message.classList.add(className);
            })

            message.classList.add("message");
            return this;
        },
        withHeader: function(text) {
            header = document.createElement("header");
            header.appendChild(document.createTextNode(text + ":"))
            return this;
        },
        withParagraph: function(text) {
            paragraph = document.createElement("p");
            paragraph.appendChild(document.createTextNode(text))
            return this;
        },
        withFooter: function(text) {
            footer = document.createElement("footer");
            footer.appendChild(document.createTextNode(text))
            return this;
        },
        build:function() {
            message.appendChild(header)
            message.appendChild(paragraph)
            message.appendChild(footer)
            return message
        }
    }

}