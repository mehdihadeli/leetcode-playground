# LeetCode Playground

[![Build-Test](https://github.com/mehdihadeli/leetcode-playground/actions/workflows/build-test.yml/badge.svg?branch=main&style=flat-square)](https://github.com/mehdihadeli/leetcode-playground/actions/workflows/build-test.yml)
[![codecov](https://codecov.io/gh/mehdihadeli/leetcode-playground/branch/main/graph/badge.svg?style=flat-square)](https://codecov.io/gh/mehdihadeli/leetcode-playground)
[![license](https://img.shields.io/github/license/mashape/apistatus.svg)](https://github.com/mehdihadeli/leetcode-playground/blob/main/LICENCE)


## Tools
- [LeetCode-OpenSource/vscode-leetcode](https://github.com/LeetCode-OpenSource/vscode-leetcode) - Solve LeetCode problems in VS Code ([Login to VS Code LeetCode](https://github.com/LeetCode-OpenSource/vscode-leetcode/issues/478#issuecomment-1046287835))

## VS Code Configurations for LeetCode

Notes: Currently, [vscode-leetcode](https://github.com/LeetCode-OpenSource/vscode-leetcode) doesn't provide [workspace based settings](https://code.visualstudio.com/docs/getstarted/settings#_workspace-settings) and it just works with [user settings](https://code.visualstudio.com/docs/getstarted/settings#_settingsjson). Please copy `.vscode/setting.json` content to your vscode [user settings](https://code.visualstudio.com/docs/getstarted/settings#_settingsjson).

``` json
{
    "leetcode.workspaceFolder": "d:\\Github\\leetcode-playground\\src\\LeetCodeSolutions",
    "leetcode.defaultLanguage": "csharp",
    "leetcode.showDescription": "Both",
    "leetcode.filePath": {
        "default": {
            "folder": "Difficulty/${difficulty}",
            "filename": "${id}.${kebab-case-name}.${ext}"
        }
    },
    "leetcode.hint.configWebviewMarkdown": false
}
```

## Problems & Solutions


|  #  |                                                           Title                                                           |                                       README                                       | Difficulty |                                            LeetCode                                            |        TAGS        |
| :-: | :-----------------------------------------------------------------------------------------------------------------------: | :--------------------------------------------------------------------------------: | :--------: | :--------------------------------------------------------------------------------------------: | :----------------: |
|  1  |                              [Two Sum](src/LeetCodeSolutions/Difficulty/Easy/1.two-sum.cs)                              |               [📗](src/LeetCodeSolutions/Difficulty/Easy/docs/1.two-sum.README.md)                |    Easy    |               [LeetCode](https://leetcode.com/problems/two-sum)                |       Array       |
|  557  |                              [Reverse Words in a String III](src/LeetCodeSolutions/Difficulty/Easy/557.reverse-words-in-a-string-iii.cs)                              |               [📗]()                |    Easy    |               [LeetCode](https://leetcode.com/problems/reverse-words-in-a-string-iii/)                |       String, Two Pointers       |


## References
- [NikiforovAll/leetcode-playground-template](https://github.com/NikiforovAll/leetcode-playground-template)
- [https://github.com/haoel/leetcode](https://github.com/haoel/leetcode)
