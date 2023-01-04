# Practice 2
if test -s $1 ; then
    echo "It is not empty"
elif test -w $1 ; then
    echo "$1 has a write permission"
else 
    echo "It is an empty one"

fi

# Practice 1
# if test -s $1 ; then
#     echo "This file is not empty"
# else 
#     echo "It is an empty one"

# fi