<h2 align="center">List of commands
</h2>


| <h3>Syntax</h3> | <h3>Description</h3> |
| ----------- | ----------- |
| <h4>**`git init`**</h4> | Initialize (create) a new local repository. Only do this once per project. |
| <h4>**`git add <file/folder>`**</h4> | Add a file or folder to the staging area. Include the name or path of the file or folder. **Do not include the angle brackets (<, >)**. |
| <h4>**`git commit -m '<message>'`**</h4> | Commit the staging area changes as a snapshot on the repository timeline. Replace <message> with a description of the changes you're making. **Do not include the angle brackets (<, >)**. |
| <h4>**`git reset HEAD <file>`**</h4> | Remove a file from staging. |
| <h4>**`git rm --cached -r .`**</h4> | Recursively(-r) remove ALL(.) files from staging. |
| <h4>**`git push`**</h4> | Push (copy) your committed changes to the remote repository (i.e. GitHub). |
| <h4>**`git pull`**</h4> | Pull (copy) changes from a remote (i.e. GitHub) repository to your computer. |
| <h4>**`git status`**</h4> | View the current changes and staging area. |
| <h4>**`git diff <file>`**</h4> | View changes to a file that are unstaged. |
| <h4>**`git diff --staged <file>`**</h4> | View changes to a file that is staged. (What lines were added, removed, and modified?) |
| <h4>**`git log`**<h4> | View list of commits in the repository snapshot timeline. |
| <h4>**`git show <commit hash>`**</h4> | View details about a particular commit. |
| <h4>**`git remote -v`**</h4> | View which remote repository (i.e. GitHub repository) this repo is linked to, if any. |
| <h4>**`git remote add origin <GitHub URL>`** | Link to a remote repository (i.e. a GitHub repo). |
| <h4>**`git push -u origin master`**</h4> | The first push to the remote repository. Sets up for future pushes with simply git push. |
| <h4>**`git clone <GitHub URL>`**</h4> | Download and link a copy of a remote GitHub repository onto your computer. This creates a new folder on your computer. |
| <h4>**`git checkout <commit hash>`**</h4> | Temporarily go back to a commit. |
| <h4>**`git checkout master`**</h4> | Return to the latest commit. |
| <h4>**`git reset --hard <commit hash>`**</h4> | Undo back to an old commit. |
| <h4>**`git push --force`**</h4> | Update GitHub after a reset. |
| <h4>**`git reset --hard origin/master`**</h4> | Reset local repo to GitHub. |
| <h4>**`git checkout -- <file>`**</h4> | Undo all changes to a file. |