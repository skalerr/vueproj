// const fs = require("fs");
// const path = require("path");

// const baseFolder =
//   process.env.APPDATA !== undefined && process.env.APPDATA !== ""
//     ? `${process.env.APPDATA}/ASP.NET/https`
//     : `${process.env.HOME}/.aspnet/https`;

// const certificateArg = process.argv
//   .map((arg) => arg.match(/--name=(?<value>.+)/i))
//   .filter(Boolean)[0];
// const certificateName = certificateArg ? certificateArg.groups.value : "vueproj";

// if (!certificateName) {
//   console.error(
//     "Invalid certificate name. Run this script in the context of an npm/yarn script or pass --name=<<app>> explicitly."
//   );
//   process.exit(-1);
// }

// const certFilePath = path.join(baseFolder, `${certificateName}.pem`);
// const keyFilePath = path.join(baseFolder, `${certificateName}.key`);

// // const sourceDir = path.resolve(__dirname, "./");
// // const styleDir = path.resolve(sourceDir, "./styles");
// // const buildDir = path.resolve("./wwwroot/");
// // const indexDir = path.resolve("./Views/Home/Index.cshtml");
// module.exports = {
//   // pages: {
//   //   index: {
//   //     // точка входа для страницы
//   //     entry: "src/main.js",
//   //     // исходный шаблон
//   //     template: "public/index.html",
//   //     // filename: "index.html",
//   //     title: "Index Page",
//   //   },
//   // },

//   devServer: {
//     // https: {
//     //   key: fs.readFileSync(keyFilePath),
//     //   cert: fs.readFileSync(certFilePath),
//     // },
//     proxy: {
//       "^/weatherforecast": {
//         target: "https://localhost:5001/",
//       },
//       "^/api/Settings": {
//         target: "http://localhost:5055/",
//       },
//       "^/api/Settings/List": {
//         target: "http://localhost:5055/",
//       },
//     },
//     port: 5002,
//   },
//   outputDir: `${buildDir}`,
//   indexPath: `${indexDir}`,
// };
module.exports = {
  publicPath: process.env.NODE_ENV === "production" ? "/vueproj/" : "/",
};
