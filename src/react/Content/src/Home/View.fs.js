import * as react from "react";
import { Msg } from "./Types.fs.js";
import { printf, toText } from "../fable_modules/fable-library.4.1.4/String.js";

export function root(model, dispatch) {
    let children, children_2;
    const children_4 = [(children = [react.createElement("input", {
        className: "input",
        type: "text",
        placeholder: "Type your name",
        defaultValue: model,
        autoFocus: true,
        onChange: (ev) => {
            dispatch(new Msg(ev.target.value));
        },
    })], react.createElement("p", {
        className: "control",
    }, ...children)), react.createElement("br", {}), (children_2 = [toText(printf("Hello %s"))(model)], react.createElement("span", {}, ...children_2))];
    return react.createElement("div", {}, ...children_4);
}

