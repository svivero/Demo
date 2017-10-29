import { FileService } from './file.service';

describe('FancyService without the TestBed', () => {
  let service: FileService;
  let dirname: String;
  let onFileContent: any;
  let onError: any;

  beforeEach(() => {
    service = new FileService();
    dirname = '';
    onFileContent = (filename: any, content: any) => {
      console.log(filename);
      console.log(content);
    };
    onError = (err) => {
      console.log(err);
    };
  });

//  it('#readFiles returns true', () => {
//    expect(service.readFiles(dirname, onFileContent, onError)).toBe(true);
//  });
});
