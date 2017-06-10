module CounterList.Types


type Model = Counter.Types.Model list

type Msg = 
| Insert
| Remove
| Modify of int * Counter.Types.Msg
