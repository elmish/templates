import { empty } from "../fable_modules/fable-library.4.1.4/List.js";

export function init() {
    return ["", empty()];
}

export function update(msg, model) {
    return [msg.fields[0], empty()];
}

