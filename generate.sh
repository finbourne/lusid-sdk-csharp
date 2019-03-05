#!/bin/bash -e

if [[ ${#1} -eq 0 ]]; then
    echo
    echo "[ERROR] swagger file not specified"
    exit 1
fi

gen_root=/usr/swagger
sdk_output_folder=$gen_root/sdk

#   remove all previously generated files
shopt -s extglob 
echo "removing previous sdk:"
rm -rf $sdk_output_folder/Lusid.Sdk/!(Utilities|*.csproj)
rm !(*.sln|*.jar|Dockerfile|docker-compose.yml)
shopt -u extglob 

# ignore files
mkdir -p $sdk_output_folder
cp /usr/src/.swagger-codegen-ignore $sdk_output_folder

echo "generating sdk"

#java -jar swagger-codegen-cli.jar swagger-codegen-cli help
java -jar swagger-codegen-cli.jar generate \
    -i $gen_root/$1 \
    -l csharp \
    -o $sdk_output_folder \
    -c $gen_root/config.json \
    -t $gen_root/templates

rm -rf $sdk_output_folder/.swagger-codegen
rm $sdk_output_folder/.gitignore
rm $sdk_output_folder/.swagger-codegen-ignore
rm $sdk_output_folder/git_push.sh
rm $sdk_output_folder/README.md
