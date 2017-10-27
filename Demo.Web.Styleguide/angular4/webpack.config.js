var ExtractTextPlugin = require('extract-text-webpack-plugin');

module.exports = {
  entry: [
   './src/main.js',
   './src/styles.scss'],

  output: {
    filename: 'src/dist/bundle.js'
  },

  watch: true,

  module: {

    rules: [
      /*
      your other rules for JavaScript transpiling go in here
      */
      { // regular css files
        test: /\.css$/,
        loader: ExtractTextPlugin.extract({
          loader: 'css-loader?importLoaders=1',
        }),
        options: {
          includePath: "./src/*/*.css"
        }
      },
      { // sass / scss loader for webpack
        test: /\.(sass|scss)$/,
        loader: ExtractTextPlugin.extract(['css-loader', 'sass-loader'])
      }
    ]
  },
  plugins: [
    new ExtractTextPlugin({ // define where to save the file
      filename: 'src/dist/[name].bundle.css',
      allChunks: true,
    }),
  ],
};
