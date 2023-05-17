import { Union } from "./fable_modules/fable-library.4.1.4/Types.js";
import { union_type } from "./fable_modules/fable-library.4.1.4/Reflection.js";

export class Page extends Union {
    constructor(tag, fields) {
        super();
        this.tag = tag;
        this.fields = fields;
    }
    cases() {
        return ["Home", "Counter", "About"];
    }
}

export function Page_$reflection() {
    return union_type("Global.Page", [], Page, () => [[], [], []]);
}

export function toHash(page) {
    switch (page.tag) {
        case 1:
            return "#counter";
        case 0:
            return "#home";
        default:
            return "#about";
    }
}

