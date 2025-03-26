import { defineConfig } from 'vite';
import path from 'path';
import autoprefixer from 'autoprefixer';
import scss from 'rollup-plugin-scss';

export default defineConfig(() => {
  const style = process.env.VITE_STYLE || 'bs5';

  console.log(path.resolve(__dirname, `${style}/styles/${style}.scss`))
  
  return {
    resolve: {
      alias: {
        '@': path.resolve(__dirname, 'src'),
      },
    },
    build: {
      outDir: path.resolve(__dirname, `${style}/dist`),
      emptyOutDir: false,
      sourcemap: true,
      rollupOptions: {
        input: {
          index: path.resolve(__dirname, 'src/ts/index.ts'),
          styles: path.resolve(__dirname, `${style}/styles/${style}.scss`), // Updated to point to the SCSS file
        },
        output: {
          entryFileNames: 'scripts.min.js',
          assetFileNames: '[name].[ext]',
        },
      },
    },
    plugins: [
      scss({
        name: "styles.min.css",
        sourceMap: true,
        outputStyle: 'compressed',
        processor: () => require('postcss')([
          autoprefixer()
        ]),
      }),
    ],
  }
});
