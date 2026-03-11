## Submission Questions

### 1. When does Git perform a fast-forward and when is a merge commit created?

* **Fast-forward:** This occurs when the base branch (`main`) has no new commits since the feature branch was created. Git simply moves the pointer forward to the latest commit.


* **Merge Commit:** This is created when the two branches have diverged, meaning both `main` and the feature branch have unique, independent commits. Git must create a new commit to join these two paths.



### 2. What is the practical difference between merge and rebase?

* **Merge:** It preserves the chronological history and shows exactly when branches were created and joined, often resulting in a "diamond" shape in the logs.


* **Rebase:** It "rewrites" history by moving the feature branch commits to the tip of `main`, creating a clean, linear history that looks like a single straight line.



### 3. How was the conflict resolved in your repository?

* In my repository, the conflict was triggered by modifying the same line in `Program.cs` on two different branches.


* I resolved it by manually editing the file in Rider, removing the Git conflict markers (`<<<<<<<`, `=======`, `>>>>>>>`), and choosing the final version of the code that allowed the application to remain functional.