import * as react from "react";

export const root = (() => {
    const children_4 = [react.createElement("h1", {}, "About page"), react.createElement("p", {}, "This template is a simple application build with Fable + Elmish + React.")];
    return react.createElement("div", {
        className: "content",
    }, ...children_4);
})();

