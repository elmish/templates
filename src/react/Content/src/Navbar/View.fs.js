import { printf, toText } from "../fable_modules/fable-library.4.1.4/String.js";
import { HTMLAttr } from "../fable_modules/Fable.React.9.3.0/Fable.React.Props.fs.js";
import { Fa_IconOption, Fa_i } from "../fable_modules/Fable.FontAwesome.3.0.0/FontAwesome.fs.js";
import { singleton } from "../fable_modules/fable-library.4.1.4/List.js";
import * as react from "react";
import { keyValueList } from "../fable_modules/fable-library.4.1.4/MapUtil.js";

export function navButton(classy, href, icon, txt) {
    let props_4, children_4, children;
    const children_6 = [(props_4 = [new HTMLAttr(64, [toText(printf("button %s"))(classy)]), new HTMLAttr(94, [href])], (children_4 = [(children = [Fa_i(singleton(icon), [])], react.createElement("span", {
        className: "icon",
    }, ...children)), react.createElement("span", {}, txt)], react.createElement("a", keyValueList(props_4, 1), ...children_4)))];
    return react.createElement("p", {
        className: "control",
    }, ...children_6);
}

export const navButtons = (() => {
    let children;
    const children_2 = [(children = [navButton("twitter", "https://twitter.com/FableCompiler", new Fa_IconOption(11, ["fab fa-twitter"]), "Twitter"), navButton("github", "https://github.com/elmish/elmish", new Fa_IconOption(11, ["fab fa-github"]), "Fork me"), navButton("github", "https://gitter.im/fable-compiler/Fable", new Fa_IconOption(11, ["fab fa-gitter"]), "Gitter")], react.createElement("div", {
        className: "field is-grouped",
    }, ...children))];
    return react.createElement("span", {
        className: "navbar-item",
    }, ...children_2);
})();

export const root = (() => {
    let children_6, children_2;
    const children_8 = [(children_6 = [(children_2 = [react.createElement("h1", {
        className: "navbar-item title is-4",
    }, "Elmish")], react.createElement("div", {
        className: "navbar-brand",
    }, ...children_2)), react.createElement("div", {
        className: "navbar-end",
    }, navButtons)], react.createElement("div", {
        className: "container",
    }, ...children_6))];
    return react.createElement("nav", {
        className: "navbar is-dark",
    }, ...children_8);
})();

