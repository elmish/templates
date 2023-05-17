import { Cmd_none } from "../fable_modules/Fable.Elmish.4.0.1/cmd.fs.js";

export function init() {
    return [0, Cmd_none()];
}

export function update(msg, model) {
    switch (msg.tag) {
        case 1:
            return [model - 1, Cmd_none()];
        case 2:
            return [0, Cmd_none()];
        default:
            return [model + 1, Cmd_none()];
    }
}

