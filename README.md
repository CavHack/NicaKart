# NicaKart
 Futuristic Entity-laden Stochastic Queues in Unity3D

---WIP -- Tread with care.

07/17/19

I am fully cognizant some of the readers might not be familiar with Unity3D, but it's far more likely that some of you are proficient with C# and .NET and will come to appreciate the architecture of the project.

Behold the 'SecurityRoom' Finite State Automata, An IsotopeDispatcher instantiates and translates an 'IsotopeOrder' with differing 'decayRates'(float) and 'shelfLife'(int). These IsotopeOrders must be stacked in four different shelves: Radioactive, Semi-Radioactive, Sub-Zero, and a dummy Overflow which will serve as a cache.  

SecurityRoom is the Object which acts as a Controller. Everything within the Unity3D ecosystem is derived (inherited) from Collections and System (two highly popular .NET libraries), including Unity Engine. A game object is a bag of components, and lives in the scene -- it shows up in the Hierarchy and is serialized into Unity's custom database format in the Library folder. Game objects can have other distinct game objects as children.

A prefab is a copy of a game object converted into a reusable asset -- it shows up in the Project folder and is serialized as a file on disk. Prefabs can contain a hierarchy of game objects.

For our quick example, it is noteworthy to highlight: once the 'IsotopeOrder' is placed on its Radioactive Shelf it begins to decay. This decay mechanism is nothing more than an arithmetic operation to subtract from the 'IsotopeOrder' a decayValue multiplier. That's four different shelves.

An 'IsotopeOrder' is spawned: When an object, string or array is created, the memory required to store it is allocated from a central pool called the heap. When the item is no longer in use, the memory it once occupied can be reclaimed and used for something else. 

The 'SecurityRoom' prefab keeps track of areas in the four heaps that it knows to be unused. When a new block of memory is requested (say when an order is instantiated and stacked), the 'SecurityRoom' chooses an unused area from which to allocate the block and then removes the allocated memory from the known unused space. Subsequent requests are handled the same way until there is no free area large enough to allocate the required 'IsotopeOrder'. It is highly unlikely at this point that all the memory allocated from the heap is still in use. A reference item on the heap can only be accessed as long as there are still reference variables that can locate it. To determine which heap blocks are no longer in use, the 'Security Room' searches through all currently active reference variables and marks the blocks they refer to as “live”. At the end of the search, any space between the live blocks is considered empty by the memory manager and can be used for subsequent allocations. For obvious reasons, the process of locating and freeing up unused memory is known as garbage collection (or GC for short).

