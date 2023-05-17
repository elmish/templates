import * as react from "react";
import { HTMLAttr } from "../fable_modules/Fable.React.9.3.0/Fable.React.Props.fs.js";
import { printf, toText } from "../fable_modules/fable-library.4.1.4/String.js";
import { keyValueList } from "../fable_modules/fable-library.4.1.4/MapUtil.js";
import { Msg } from "./Types.fs.js";

export function simpleButton(txt, action, dispatch) {
    const children_2 = [react.createElement("a", {
        className: "button",
        onClick: (_arg) => {
            dispatch(action);
        },
    }, txt)];
    return react.createElement("div", {
        className: "column is-narrow",
    }, ...children_2);
}

export function root(model, dispatch) {
    let props_2, children_2;
    const children_6 = [react.createElement("div", {
        className: "column",
    }), (props_2 = [new HTMLAttr(64, ["column is-narrow"]), ["style", {
        width: "170px",
    }]], (children_2 = [toText(printf("Counter value: %i"))(model)], react.createElement("div", keyValueList(props_2, 1), ...children_2))), simpleButton("+1", new Msg(0, []), dispatch), simpleButton("-1", new Msg(1, []), dispatch), simpleButton("Reset", new Msg(2, []), dispatch), react.createElement("div", {
        className: "column",
    })];
    return react.createElement("div", {
        className: "columns is-vcentered",
    }, ...children_6);
}

