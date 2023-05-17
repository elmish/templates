import { Union } from "../fable_modules/fable-library.4.1.4/Types.js";
import { union_type } from "../fable_modules/fable-library.4.1.4/Reflection.js";

export class Msg extends Union {
    constructor(tag, fields) {
        super();
        this.tag = tag;
        this.fields = fields;
    }
    cases() {
        return ["Increment", "Decrement", "Reset"];
    }
}

export function Msg_$reflection() {
    return union_type("Counter.Types.Msg", [], Msg, () => [[], [], []]);
}

