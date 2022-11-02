# Instalacja

```console
npm init -y
npm i typescript --save-dev
npx tsc -int

//tsconfig.json
"module" : "ES6",
 "target": "es2022",
"outDir": "./dist",
"rootDir": "./src"

```
# Instalcja webpack

```conosole
npm i webpack --save-dev
npm i webpack-cli --save-dev
npm i ts-loader --save-dev
```

# wbpack.config.js
```js
module.exports = {
    mode: 'development',
    devtool: 'inline-source-map',
    entry: {filename: 'bundle.js'},
    resolve: { extensions: ['.ts','.js']},
    module: {
        rules: [
            { test:/\.ts/,use: 'ts-loader',exclude: /node_modules/}
        ],
    },
    devServer: {
        static: './public', port: 4500,
    }
};

```
