## Task 4: Fast-Forward Merge

For this task, a new branch `feature-average` was created to implement the `CalculateAverage` method. 

* **Process**: After committing the changes to the feature branch, I switched back to `main`. 


* **Result**: Since no new commits were made on `main` during this time, Git performed a **Fast-Forward** merge, simply moving the `main` pointer to the latest commit of the feature branch. 



## Task 5: Merge without Fast-Forward

A new branch `feature-max` was created to implement the `CalculateMax` method. 

* **Divergence**: Before merging, an independent commit was added directly to `main` (updating this README). 


* **Result**: Because both branches now had unique, different commits, a **Merge Commit** was created to join the two paths. 


* **Why not Fast-Forward?**: Git could not perform a Fast-Forward because the history had diverged; there was no linear path from the base of the feature branch to the new tip of `main`. 