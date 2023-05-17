import { Record, Union } from "./fable_modules/fable-library.4.1.4/Types.js";
import { Msg_$reflection as Msg_$reflection_1 } from "./Counter/Types.fs.js";
import { Msg_$reflection as Msg_$reflection_2 } from "./Home/Types.fs.js";
import { record_type, string_type, int32_type, union_type } from "./fable_modules/fable-library.4.1.4/Reflection.js";
import { Page_$reflection } from "./Global.fs.js";

export class Msg extends Union {
    constructor(tag, fields) {
        super();
        this.tag = tag;
        this.fields = fields;
    }
    cases() {
        return ["CounterMsg", "HomeMsg"];
    }
}

export function Msg_$reflection() {
    return union_type("App.Types.Msg", [], Msg, () => [[["Item", Msg_$reflection_1()]], [["Item", Msg_$reflection_2()]]]);
}

export class Model extends Record {
    constructor(CurrentPage, Counter, Home) {
        super();
        this.CurrentPage = CurrentPage;
        this.Counter = (Counter | 0);
        this.Home = Home;
    }
}

export function Model_$reflection() {
    return record_type("App.Types.Model", [], Model, () => [["CurrentPage", Page_$reflection()], ["Counter", int32_type], ["Home", string_type]]);
}

