Steps to Create a New Branch:

Create a new branch locally: To create a new branch, run:
git checkout -b <new-branch-name>
For example, if you want to create a branch called feature/new-feature, you would run:

Switch Between Branches
To switch between branches, use the git checkout command:
git checkout <branch-name>


Use git revert (safe, preserves history)
git log
Revert the merge: Once you have the merge commit hash, run:
git revert -m 1 <merge-commit-hash>
Push the revert to GitHub: If you’ve already pushed the merged branch, you’ll want to push the revert commit:
git push origin master

How to create a branch from a Git commit
1. Find the commit id
git log --oneline
2. Creating the branch
git checkout -b <new-branch-name> <commit-hash>
