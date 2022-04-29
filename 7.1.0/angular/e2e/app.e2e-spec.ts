import { L2LabTemplatePage } from './app.po';

describe('L2Lab App', function() {
  let page: L2LabTemplatePage;

  beforeEach(() => {
    page = new L2LabTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
