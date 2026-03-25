import { defineConfig } from 'vite';
import { resolve } from 'path';
import * as sass from 'sass';
import autoprefixer from 'autoprefixer';
import postcss from 'postcss';

// Get the style from environment variable (bs3, bs4, or bs5)
const style = process.env.STYLE || 'bs3';

export default defineConfig({
  // Root directory for the build
  root: '.',
  
  // Build configuration
  build: {
    // Output directory: bs3/dist, bs4/dist, or bs5/dist
    outDir: `${style}/dist`,
    
    // Generate source maps
    sourcemap: true,
    
    // Empty output directory before build
    emptyOutDir: false,
    
    // Asset file names
    assetsDir: 'images',
    
    // Rollup options
    rollupOptions: {
      input: {
        scripts: resolve(process.cwd(), 'src/ts/index.ts'),
      },
      output: {
        // Output file naming
        entryFileNames: '[name].min.js',
        chunkFileNames: '[name].min.js',
        assetFileNames: (assetInfo) => {
          // CSS files go to root of dist
          if (assetInfo.name?.endsWith('.css')) {
            // Extract the entry name from source (styles from styles-entry)
            const name = assetInfo.name.includes('entry') ? 'styles' : assetInfo.name.replace('.css', '');
            return `${name}.min.css`;
          }
          // Other assets (images, fonts, etc.) go to images folder
          return 'images/[name].[hash][extname]';
        },
      },
    },
    
    // Minification
    minify: 'esbuild',
    
    // Target browsers
    target: 'es2020',
    
    // CSS code splitting
    cssCodeSplit: false,
  },
  
  // CSS configuration
  css: {
    preprocessorOptions: {
      scss: {
        // Silence deprecation warnings (equivalent to webpack config)
        api: 'modern',
        silenceDeprecations: ['mixed-decls', 'color-functions', 'global-builtin', 'import'],
      },
    },
    postcss: {
      plugins: [
        // Autoprefixer for vendor prefixes
        require('autoprefixer')(),
      ],
    },
  },
  
  // TypeScript configuration
  resolve: {
    extensions: ['.ts', '.js', '.scss', '.css'],
  },
  
  // Server configuration (for development)
  server: {
    watch: {
      usePolling: true,
    },
  },
  
  // Plugins
  plugins: [
    {
      name: 'compile-scss-to-css',
      async generateBundle(options, bundle) {
        // Compile the SCSS file directly
        const scssPath = resolve(process.cwd(), `${style}/styles/${style}.scss`);
        
        try {
          // Compile SCSS to CSS
          const result = sass.compile(scssPath, {
            sourceMap: true,
            style: 'compressed',
            silenceDeprecations: ['mixed-decls', 'color-functions', 'global-builtin', 'import'],
          });
          
          // Apply PostCSS (autoprefixer)
          const postcssResult = await postcss([autoprefixer()]).process(result.css, {
            from: scssPath,
            to: 'styles.min.css',
            map: { 
              inline: false, 
              annotation: true,
              prev: result.sourceMap ? JSON.stringify(result.sourceMap) : false,
            },
          });
          
          // Add the CSS file to the bundle
          this.emitFile({
            type: 'asset',
            fileName: 'styles.min.css',
            source: postcssResult.css,
          });
          
          // Add the source map
          if (postcssResult.map) {
            this.emitFile({
              type: 'asset',
              fileName: 'styles.min.css.map',
              source: postcssResult.map.toString(),
            });
          }
          
          console.log('✓ CSS compiled successfully');
        } catch (error) {
          console.error('Error compiling SCSS:', error);
          throw error;
        }
        
        // Remove the styles.min.js file since it's not needed
        if (bundle['styles.min.js']) {
          delete bundle['styles.min.js'];
        }
        if (bundle['styles.min.js.map']) {
          delete bundle['styles.min.js.map'];
        }
      },
    },
    {
      name: 'progress-plugin',
      buildStart() {
        console.log(`\nBuilding ${style}...`);
      },
      buildEnd() {
        console.log(`✓ Build complete for ${style}\n`);
      },
    },
  ],
  
  // Optimization
  optimizeDeps: {
    include: ['typescript'],
  },
});
