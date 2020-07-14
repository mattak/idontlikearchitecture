# application architecture comparation


## Spec

- count is incremented by ui button
- count is displayed on ui text
- count is saved to playerprefs
- initial count is loaded from playerprefs

## Project

`baseline`

- libraries
  - nothing

`cafu_v3_sample`

- libraries
  - unitask
  - zenject
  - unirx


## Stats


files

```
$ find baseline/Assets/Scripts -type f -name '*.cs' | wc -l
       1
$ find cafu_v3_sample/Assets/Scripts -type f -name '*.cs' | wc -l
      15
```

lines

```
$ find baseline/Assets/Scripts -type f -name '*.cs' | xargs -n1 cat | wc -l
      28
$ find cafu_v3_sample/Assets/Scripts -type f -name '*.cs' | xargs -n1 cat | wc -l
     241
```

