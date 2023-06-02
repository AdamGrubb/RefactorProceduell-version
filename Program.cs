using HemsideGenerator.Controller;
using HemsideGenerator.Model;
using HemsideGenerator.View;

MockApCall mockApCall = new MockApCall();

ConsoleView consoleView = new ConsoleView();

PrintToFile printToFile = new PrintToFile();

HemsideGeneratorController controller = new HemsideGeneratorController(mockApCall, consoleView);

controller.printPage();