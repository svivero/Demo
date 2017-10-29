import { Injectable } from '@angular/core';
import * as fs from 'fs';

@Injectable()
export class FileService {

  constructor() { }

  // https://stackoverflow.com/questions/10049557/reading-all-files-in-a-directory-store-them-in-objects-and-send-the-object
  readFiles(dirname, onFileContent, onError) {
    fs.readdir(dirname, function(err, filenames) {
      if (err) {
        onError(err);
        return;
      }
      filenames.forEach(function(filename) {
        fs.readFile(dirname + filename, 'utf-8', function(err, content) {
          if (err) {
            onError(err);
            return;
          }
          onFileContent(filename, content);
        });
      });
    });
  }
}
