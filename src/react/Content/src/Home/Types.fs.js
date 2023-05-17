import { Union } from "../fable_modules/fable-library.4.1.4/Types.js";
import { union_type, string_type } from "../fable_modules/fable-library.4.1.4/Reflection.js";

export class Msg extends Union {
    constructor(Item) {
        super();
        this.tag = 0;
        this.fields = [Item];
    }
    cases() {
        return ["ChangeStr"];
    }
}

export function Msg_$reflection() {
    return union_type("Home.Types.Msg", [], Msg, () => [[["Item", string_type]]]);
}

