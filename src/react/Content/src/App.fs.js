import { Helpers_classList } from "./fable_modules/Fable.React.9.3.0/Fable.React.Helpers.fs.js";
import { equals } from "./fable_modules/fable-library.4.1.4/Util.js";
import { Page, toHash } from "./Global.fs.js";
import { HTMLAttr } from "./fable_modules/Fable.React.9.3.0/Fable.React.Props.fs.js";
import * as react from "react";
import { keyValueList } from "./fable_modules/fable-library.4.1.4/MapUtil.js";
import { root as root_1 } from "./Navbar/View.fs.js";
import { root as root_2 } from "./Counter/View.fs.js";
import { Msg } from "./Types.fs.js";
import { root as root_3 } from "./Home/View.fs.js";
import { root as root_4 } from "./Info/View.fs.js";
import { ProgramModule_run } from "./fable_modules/Fable.Elmish.HMR.7.0.0/../Fable.Elmish.4.0.1/program.fs.js";
import { Program_withReactBatched } from "./fable_modules/Fable.Elmish.HMR.7.0.0/../Fable.Elmish.React.4.0.0/react.fs.js";
import { ProgramModule_toNavigable } from "./fable_modules/Fable.Elmish.Browser.4.0.1/navigation.fs.js";
import { parseHash } from "./fable_modules/Fable.Elmish.Browser.4.0.1/parser.fs.js";
import { update, init, urlUpdate as urlUpdate_1, pageParser } from "./State.fs.js";
import { ProgramModule_mkProgram } from "./fable_modules/Fable.Elmish.4.0.1/program.fs.js";
import "../sass/main.sass";


export function menuItem(label, page, currentPage) {
    let props;
    const children_2 = [(props = [Helpers_classList([["is-active", equals(page, currentPage)]]), new HTMLAttr(94, [toHash(page)])], react.createElement("a", keyValueList(props, 1), label))];
    return react.createElement("li", {}, ...children_2);
}

export function menu(currentPage) {
    let children_2;
    const children_4 = [react.createElement("p", {
        className: "menu-label",
    }, "General"), (children_2 = [menuItem("Home", new Page(0, []), currentPage), menuItem("Counter sample", new Page(1, []), currentPage), menuItem("About", new Page(2, []), currentPage)], react.createElement("ul", {
        className: "menu-list",
    }, ...children_2))];
    return react.createElement("aside", {
        className: "menu",
    }, ...children_4);
}

export function root(model, dispatch) {
    let children_8, children_6, children_4, children, children_2, page;
    const children_10 = [root_1, (children_8 = [(children_6 = [(children_4 = [(children = [menu(model.CurrentPage)], react.createElement("div", {
        className: "column is-3",
    }, ...children)), (children_2 = [(page = model.CurrentPage, (page.tag === 1) ? root_2(model.Counter, (arg_1) => {
        dispatch(new Msg(0, [arg_1]));
    }) : ((page.tag === 0) ? root_3(model.Home, (arg_3) => {
        dispatch(new Msg(1, [arg_3]));
    }) : root_4))], react.createElement("div", {
        className: "column",
    }, ...children_2))], react.createElement("div", {
        className: "columns",
    }, ...children_4))], react.createElement("div", {
        className: "container",
    }, ...children_6))], react.createElement("div", {
        className: "section",
    }, ...children_8))];
    return react.createElement("div", {}, ...children_10);
}

ProgramModule_run(Program_withReactBatched("elmish-app", ProgramModule_toNavigable((location) => parseHash(pageParser, location), urlUpdate_1, ProgramModule_mkProgram(init, update, root))));

